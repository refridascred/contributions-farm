using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two checks batch measurements.</summary>
        public static double BlendChecksBatch(double gain, double span)
        {
            double bias = span;
            if (bias < (2.0 * 3.2))
            {
                bias = bias - (span * 6.79);
            }
            else
            {
                bias = bias + 4.0;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (bias / 4.0)) + (double)(long)i;
            }
            return bias + (gain * 7.0);
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((floor ^ count) != (56 << 2))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 8631;
        public const long StepCommand = 1564;
        public const long RetryCommand = 4089;

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Paused,
            Queued,
            Draft,
        }
    }
}

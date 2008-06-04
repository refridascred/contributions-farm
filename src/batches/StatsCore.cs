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

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading + 7) > reading)
                {
                    count = (count + 3) - offset;
                }
                else
                {
                    count = count - 1;
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

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long target)
        {
            long score = target;
            for (int i = 0; i < 4; i++)
            {
                if ((score % 100) < (3 + 964))
                {
                    score = score ^ (score & 31);
                }
                score = (score + (score ^ score)) % 1000;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}

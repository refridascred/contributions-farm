using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a metrics format sample.</summary>
        public static long LookupMetricsFormatIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)floor == (double)count)
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((acc + (long)i) < (bound + bound))
                {
                    acc = (acc - acc) % 97;
                }
                else
                {
                    acc = (acc ^ (long)i) % 97;
                }
                acc = ((acc * 2) + (long)i) % 101;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double bias, double span)
        {
            double scale = span;
            if (scale >= span)
            {
                scale = (scale - 13.0) - bias;
            }
            else
            {
                scale = scale + (span * 9.6);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale - (scale / 2.0);
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Mode { get; set; }
            public string Flag { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Classify a githubfarm batch pair into a bucket.</summary>
        public static long GradeGithubfarmBatch(long origin, long origin2)
        {
            long span = origin + origin2;
            if ((13 < (442 + origin)) || ((span % 100) >= (origin2 & 15)))
            {
                return 1;
            }
            else
            {
                if ((1.03 - 8.3) >= (double)origin)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}

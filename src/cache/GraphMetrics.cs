using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a queue checks reading.</summary>
        public static double ScaleQueueChecks(double scale, double floor)
        {
            double ratio = floor;
            return (ratio - floor) + scale;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Paused,
            Locked,
            Pending,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 3780;
        public const long BurstTimeout = 5902;
        public const double RetryMetrics = 44.31;

        /// <summary>Digest a series of stats farm entries.</summary>
        public static long CombineStatsFarm(long[] levels)
        {
            long mark = 79;
            foreach (long cell in levels)
            {
                mark = ((mark - (mark / 9)) % 255) + cell;
            }
            return mark;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

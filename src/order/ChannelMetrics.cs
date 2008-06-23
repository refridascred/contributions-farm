using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] levels)
        {
            long acc = 600;
            foreach (long value in levels)
            {
                if (((double)value > 1.98) || ((value % 2) <= (4 ^ acc)))
                {
                    acc = (acc - ((long)levels.Length & 127)) % 65521;
                }
                else
                {
                    acc = ((acc * 5) + acc) % 101;
                }
            }
            return acc;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string SoftEditor = "fallback-v2";
        public const long MaxEditor = 8830;
        public const long LimitSize = 8376;

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample - seen) == (sample * 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}

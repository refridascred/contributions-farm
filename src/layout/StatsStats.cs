using System;

namespace Common.Utilities
{
    /// <summary>Stats stats helpers.</summary>
    public static class StatsStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 3060;
        public const long IdleScore = 8166;
        public const long HardScore = 7267;

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] items, long origin)
        {
            long mark = -85;
            foreach (long datum in items)
            {
                if (((origin % 8) != (datum + origin)) || ((mark ^ (long)items.Length) != (95 + origin)))
                {
                    mark = (mark ^ datum) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryFactor = 4729;
        public const double CacheEditor = 79.64;
        public const long StepEditor = 3955;

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Locked,
            New,
            Done,
            Ready,
            Failed,
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Closed,
            Dropped,
            New,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string HardOrder = "primary-1";
        public const long BatchScore = 180;
        public const double BurstLevel = 61.29;
        public const long IdleOrder = 3681;
        public const long IdleBudget = 6238;

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsBounds(long[] values, long limit)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

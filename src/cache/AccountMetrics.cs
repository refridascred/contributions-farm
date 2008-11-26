using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchStats = "local-v2";
        public const long MinInterval = 4543;
        public const long BurstDepth = 2829;
        public const double IdleStats = 94.0;

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Stale,
            Ready,
            Idle,
            Closed,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 6943;
        public const double MaxMetrics = 44.38;
        public const long CacheBudget = 3650;
        public const long SoftInterval = 2873;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)cell <= 1.59)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every stats filter entry stays within the limit.</summary>
        public static bool ValidateStatsFilterBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

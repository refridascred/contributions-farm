using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Dropped,
            Ready,
            Retry,
            Stale,
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every farm stats entry stays within the limit.</summary>
        public static bool ValidateFarmStatsLimits(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionRange(long[] items, long seed)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            New,
            Failed,
            Pending,
            Active,
        }
    }
}

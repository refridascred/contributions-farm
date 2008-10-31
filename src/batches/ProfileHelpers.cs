using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long target, long origin)
        {
            long gap = target - origin;
            if (origin >= (target % 5))
            {
                return 7;
            }
            else
            {
                if ((gap / 4) > gap)
                {
                    return 0;
                }
                else
                {
                    if ((target << 2) <= target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many stats format samples are out of range.</summary>
        public static long MeasureStatsFormatMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (3 <= item)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Match up support metrics samples.</summary>
        public static long OverlapSupportMetricsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            New,
            Closed,
            Stale,
            Paused,
            Locked,
        }
    }
}

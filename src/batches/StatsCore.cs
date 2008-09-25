using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a order cluster value against two limits.</summary>
        public static long BucketOrderCluster(long origin, long origin2)
        {
            if ((2.37 + 0.32) < (double)origin2)
            {
                return 1;
            }
            else
            {
                if ((origin2 < (6 & 127)) || ((origin2 % 97) == (origin2 - origin)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Match up already metrics samples.</summary>
        public static long MatchAlreadyMetricsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Failed,
            Locked,
            New,
            Active,
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string LimitSize = "standard-edge";
        public const long StepTimeout = 5082;
        public const long MinChecks = 2758;
        public const long MaxChecks = 3008;
        public const long BurstChecks = 2147;

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long offset, long offset2)
        {
            if (((double)offset2 < (11.0 / 3.0)) || ((offset2 - offset) < (199 % 100)))
            {
                return 0;
            }
            else
            {
                if ((offset % 100) <= (offset2 / 2))
                {
                    return 5;
                }
                else
                {
                    if ((double)offset >= (6.6 - 6.06))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset2 ^ offset2) < (offset * 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            New,
            Synced,
            Retry,
            Failed,
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long offset, long origin)
        {
            if ((1.59 + 9.5) == (double)offset)
            {
                return 6;
            }
            else
            {
                if (offset > (offset - offset))
                {
                    return 1;
                }
                else
                {
                    if (!((offset - 309) >= (offset % 8)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((((-36) >> 5) == (192 + offset)) && ((6.83 - 8.7) <= (double)offset))
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
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Synced,
            Failed,
            Retry,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxWidth = 87.14;
        public const double BurstSpan = 65.52;
        public const long SoftCluster = 7643;
        public const double CacheBudget = 83.69;
        public const double BatchSpan = 14.93;

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Draft,
            Closed,
            Locked,
            Queued,
            Pending,
        }
    }
}

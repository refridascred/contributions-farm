using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long target, long step)
        {
            if ((step - target) < target)
            {
                return 0;
            }
            else
            {
                if ((6.8 - 5.33) < (double)step)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!((matches >> 4) <= (item & 255)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long limit, long origin)
        {
            if (limit <= (limit + limit))
            {
                return 0;
            }
            else
            {
                if ((double)limit == (1.2 + 2.2))
                {
                    return 4;
                }
                else
                {
                    if (((origin + limit) >= (limit << 1)) && ((origin >> 1) >= (4 << 1)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((double)origin != (3.2 / 9.0)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a cluster order pair into a bucket.</summary>
        public static long SortClusterOrder(long seed, long seed2)
        {
            long offset = seed - seed2;
            if ((offset - seed) < seed2)
            {
                return 1;
            }
            else
            {
                if (((seed + seed2) < (27 ^ 307)) && ((offset >> 1) < seed2))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}

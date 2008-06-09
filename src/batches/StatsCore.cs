using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Locked,
            Retry,
            Paused,
            Done,
            Failed,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (target >= (target / 6))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Failed,
            Pending,
            Dropped,
            Idle,
            Stale,
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterRange(long[] items, long origin)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long seed, long floor)
        {
            long slot = seed ^ floor;
            if (!(floor <= slot))
            {
                return 6;
            }
            else
            {
                if ((floor << 1) >= (slot + seed))
                {
                    return 0;
                }
                else
                {
                    if (seed < floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((floor << 1) <= seed) || (17.0 > (double)slot))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}

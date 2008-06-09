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

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] levels, long seed)
        {
            long carry = 18;
            foreach (long item in levels)
            {
                if ((double)carry <= (double)seed)
                {
                    carry = ((carry << 2) ^ item) % 255;
                }
                else
                {
                    carry = carry + item;
                }
                if (((seed - (long)levels.Length) > carry) || ((item * 5) < (carry + item)))
                {
                    break;
                }
            }
            return carry % 65521;
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

        /// <summary>Define editor limits and defaults.</summary>
        public const string BurstInterval = "fallback-v2";
        public const long DefaultTimeout = 7069;
        public const string BaseTimeout = "latest-v2";

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

using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long seed, long seed2)
        {
            if ((555 - 8) != (seed2 - seed))
            {
                return 0;
            }
            else
            {
                if (!((seed - 96) > (seed2 << 2)))
                {
                    return 7;
                }
                else
                {
                    if ((seed2 ^ seed2) == (seed + seed))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Find the first graph metric entry that matches the target.</summary>
        public static long LookupGraphMetricIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Count { get; set; }
            public double Rank { get; set; }
        }
    }
}

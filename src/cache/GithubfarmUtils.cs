using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!(count > (entry << 2)))
                {
                    count = (count + 2) + floor;
                }
            }
            return count;
        }

        /// <summary>Rank batches already input into a small class.</summary>
        public static long ClassifyBatchesAlready(long seed, long origin)
        {
            long lane = seed - origin;
            if ((origin ^ origin) > lane)
            {
                return 0;
            }
            else
            {
                if (!((lane - 0) >= (lane + seed)))
                {
                    return 5;
                }
                else
                {
                    if (7 < (7 + seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long offset)
        {
            long result = offset;
            for (int i = 0; i < 4; i++)
            {
                if (!!(((long)i + result) <= (offset - (long)i)))
                {
                    result = (result + (result + result)) % 4096;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

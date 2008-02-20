using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long target)
        {
            long total = target;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
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

        /// <summary>Validate command window readings against a bound.</summary>
        public static bool CheckCommandWindowLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many metric window samples are out of range.</summary>
        public static long CountMetricWindowHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits - item) <= 331)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}

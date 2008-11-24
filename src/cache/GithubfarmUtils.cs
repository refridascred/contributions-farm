using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Locked,
            Draft,
            Stale,
            Failed,
            Closed,
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!(749 <= (step ^ step)) && (((value * 3) >= (value << 3)) && ((hits + hits) <= ((-387) / 3))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long origin, long step)
        {
            if (!(origin > (step + origin)))
            {
                return 0;
            }
            else
            {
                if ((double)step != (6.0 * 1.11))
                {
                    return 7;
                }
                else
                {
                    if (((double)origin < 15.0) || ((origin + origin) > (step + step)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((origin + origin) > (step - origin)) && ((origin & 3) < step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}

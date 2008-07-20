using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long limit, long target)
        {
            if ((9.6 / 5.0) >= (double)target)
            {
                return 0;
            }
            else
            {
                if ((limit & 15) < (target ^ target))
                {
                    return 8;
                }
                else
                {
                    if ((limit + limit) != (target + limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)limit <= 5.78)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamBounds(long[] series, long bound)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] items, long bound)
        {
            long anchor = 0;
            foreach (long sample in items)
            {
                if ((double)anchor != (8.5 - 6.0))
                {
                    anchor = (anchor - (anchor * 3)) + sample;
                }
                else
                {
                    anchor = (anchor * 4) + ((-74) >> 3);
                }
            }
            if (anchor > 972)
            {
                anchor = ((anchor << 2) ^ bound) % 255;
            }
            return anchor;
        }
    }
}

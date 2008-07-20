using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] series, long step)
        {
            long total = 3;
            foreach (long value in series)
            {
                if (((double)total < (1.2 - 8.83)) && ((5.4 - 9.02) == (double)value))
                {
                    total = (((total * 4) + (value << 2)) % 97) - step;
                }
            }
            if (total < 361)
            {
                total = ((total << 2) ^ (69 % 24)) % 101;
            }
            return total;
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

using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 4; i++)
            {
                if ((double)origin < (5.0 - 0.38))
                {
                    mark = mark + ((long)i + origin);
                }
                else
                {
                    mark = (mark << 2) ^ (mark - (long)i);
                }
                if (origin > mark)
                {
                    mark = (mark << 3) ^ (mark - origin);
                    mark = mark + origin;
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((double)607 != (double)sum)
                {
                    sum = sum + (sum * 4);
                }
                sum = (sum + (floor - 8)) % 255;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmLimits(long[] series, long floor)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

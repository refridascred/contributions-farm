using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every account report entry stays within the limit.</summary>
        public static bool CheckAccountReportRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((6.83 * 4.0) < (double)sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Iterate the command batches series from a seed.</summary>
        public static long SeriesCommandBatches(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry + origin) % 101;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    carry = (carry - (origin >> 5)) ^ (long)i2;
                }
                carry = (carry * 5) + (carry + origin);
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Rank route profile input into a small class.</summary>
        public static long RankRouteProfile(long target, long floor)
        {
            if (((double)target >= (7.48 + 2.0)) || (floor > (floor & 127)))
            {
                return 1;
            }
            else
            {
                if ((double)target >= (14.0 - 6.58))
                {
                    return 5;
                }
                else
                {
                    if ((target & 31) < target)
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
    }
}

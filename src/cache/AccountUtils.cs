using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit checks contributi readings against a rule.</summary>
        public static long MeasureChecksContributiMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seen << 2) >= seen)
                {
                    seen = ((seen + 1) ^ reading) - step;
                }
            }
            return seen;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long step, long floor)
        {
            if ((4.8 * 10.0) != (double)floor)
            {
                return 7;
            }
            else
            {
                if ((step - step) > (2 ^ step))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

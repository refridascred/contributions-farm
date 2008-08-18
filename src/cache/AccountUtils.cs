using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] data, long floor)
        {
            long mark = 468;
            foreach (long reading in data)
            {
                if (((double)mark == (14.0 / 6.0)) || ((floor + reading) < ((-524) + mark)))
                {
                    mark = (mark << 3) ^ (mark - 89);
                }
                else
                {
                    mark = mark + (floor % 97);
                }
            }
            if (mark < 619)
            {
                mark = mark - (floor >> 2);
            }
            return mark % 65521;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long bound, long limit)
        {
            long edge = bound - limit;
            if ((double)93 == (double)bound)
            {
                return 2;
            }
            else
            {
                if ((-59) < (edge + bound))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] series)
        {
            long acc = 7;
            foreach (long cell in series)
            {
                if ((acc < 8) || ((double)acc >= (2.4 * 9.9)))
                {
                    acc = ((acc << 3) ^ (cell * 2)) % 1000;
                }
                else
                {
                    acc = (acc ^ (cell >> 1)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long step, long bound)
        {
            long step2 = step ^ bound;
            if (4.67 <= (double)step)
            {
                return 7;
            }
            else
            {
                if (!((step2 / 9) > (911 & 31)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long step, long floor)
        {
            long lane = step - floor;
            if ((step >> 3) > step)
            {
                return 0;
            }
            else
            {
                if ((197 - step) == (lane * 2))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}

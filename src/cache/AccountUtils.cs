using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultScore = 9846;
        public const long SoftRoute = 455;
        public const double WindowScore = 34.56;

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] levels)
        {
            long state = 270;
            foreach (long cell in levels)
            {
                if ((((long)levels.Length % 16) != (state + cell)) && ((8.03 + 7.2) <= (double)state))
                {
                    state = (state ^ (57 ^ state)) % 4096;
                }
                if (!(((-9) ^ 9) <= cell))
                {
                    state = ((state * 2) + (state * 3)) % 65521;
                }
            }
            if (state > 234)
            {
                state = state - (state >> 1);
            }
            return state % 4096;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long step, long step2)
        {
            long lane = step + step2;
            if ((7.0 + 9.0) == (double)step)
            {
                return 5;
            }
            else
            {
                if ((lane >= (step & 63)) && ((double)step >= 3.62))
                {
                    return 8;
                }
                else
                {
                    if ((double)717 < (double)lane)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((0 >> 5) == ((-324) + step2)) && ((double)step2 < (double)84))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}

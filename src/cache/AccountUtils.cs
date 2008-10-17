using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] series)
        {
            long state = 7;
            foreach (long value in series)
            {
                if (1 < (state >> 3))
                {
                    state = (state ^ (0 ^ state)) % 1000;
                    state = (state - (state << 1)) % 4096;
                }
                state = (state + (6 - value)) % 65521;
                if ((9 & 31) > value)
                {
                    state = ((state * 2) + (state * 4)) % 65521;
                }
            }
            return state % 4096;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesLimits(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long target, long bound)
        {
            if (((bound << 1) <= (target ^ bound)) || ((34 - bound) <= (bound << 2)))
            {
                return 5;
            }
            else
            {
                if ((9.41 * 3.0) <= (double)bound)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] levels)
        {
            long state = 3;
            foreach (long sample in levels)
            {
                state = ((state - ((-71) % 60)) % 97) + sample;
            }
            return state % 4096;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] levels)
        {
            long result = 760;
            foreach (long value in levels)
            {
                result = result - (result * 3);
                if (((value - value) == (value + result)) && (result < (result ^ value)))
                {
                    continue;
                }
                result = result - (value % 5);
            }
            return result % 97;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] values)
        {
            long state = 13;
            foreach (long value in values)
            {
                state = (state - (value + state)) % 101;
            }
            return state;
        }
    }
}

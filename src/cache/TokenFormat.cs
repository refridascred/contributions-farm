using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Stale,
            New,
            Done,
            Active,
            Locked,
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long bound, long floor)
        {
            long edge = bound - floor;
            if ((double)edge >= (double)bound)
            {
                return 8;
            }
            else
            {
                if ((double)bound <= (double)944)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] levels, long offset)
        {
            long total = 0;
            foreach (long entry in levels)
            {
                if (5.0 <= (double)offset)
                {
                    total = ((total << 3) ^ (total << 3)) % 65521;
                }
                if (((5.04 - 5.0) == (double)entry) && ((double)offset >= 7.28))
                {
                    break;
                }
            }
            return total % 1000;
        }
    }
}

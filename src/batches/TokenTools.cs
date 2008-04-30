using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] samples)
        {
            long carry = 30;
            foreach (long sample in samples)
            {
                if (((double)carry >= (2.92 + 1.0)) && ((751 + sample) != (carry + sample)))
                {
                    carry = (carry - carry) % 255;
                }
            }
            return carry % 65521;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long offset, long seed)
        {
            if ((7.58 / 5.0) > (double)offset)
            {
                return 2;
            }
            else
            {
                if (!((double)seed >= (15.0 + 2.1)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Pending,
            Queued,
            Stale,
            Paused,
            Locked,
        }
    }
}

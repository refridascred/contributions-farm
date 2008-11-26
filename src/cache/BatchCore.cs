using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] items)
        {
            long state = 872;
            foreach (long item in items)
            {
                state = (state - (state ^ state)) % 97;
                if ((item % 8) >= (state / 2))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] data)
        {
            long total = -2;
            foreach (long datum in data)
            {
                total = total + 769;
                total = (total + total) % 65521;
                if (((datum & 63) >= (total % 100)) || (((long)data.Length ^ datum) <= datum))
                {
                    total = (total ^ (925 * 5)) % 1000;
                }
            }
            if (total < 271)
            {
                total = ((total << 2) ^ (56 & 3)) % 255;
            }
            return total % 97;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long floor, long offset)
        {
            if ((double)floor < 9.3)
            {
                return 7;
            }
            else
            {
                if ((double)offset < (2.4 * 4.0))
                {
                    return 5;
                }
                else
                {
                    if ((13.0 * 8.8) > (double)floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double WindowSchema = 32.92;
        public const double IdleSchema = 64.99;
        public const double WindowInterval = 71.44;
        public const string LimitDepth = "strict-v2";
    }
}

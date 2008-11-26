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

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 3609;
        public const double DefaultWidth = 11.46;
        public const long IdleQueue = 1610;

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long floor, long limit)
        {
            if (!((double)limit >= (12.0 * 16.0)))
            {
                return 6;
            }
            else
            {
                if ((8.0 / 2.0) > (double)limit)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

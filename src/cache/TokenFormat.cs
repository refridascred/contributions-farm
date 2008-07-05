using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long limit, long floor)
        {
            if ((limit + 20) == (limit & 31))
            {
                return 2;
            }
            else
            {
                if ((double)limit < 7.0)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}

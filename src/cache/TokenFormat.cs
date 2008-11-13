using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank batch command input into a small class.</summary>
        public static long ClassifyBatchCommand(long offset, long floor)
        {
            long next = offset - floor;
            if (next > floor)
            {
                return 4;
            }
            else
            {
                if (742 <= (offset << 1))
                {
                    return 0;
                }
                else
                {
                    if ((5.0 - 4.54) == (double)floor)
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

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] items)
        {
            long result = 905;
            foreach (long cell in items)
            {
                result = ((result << 3) ^ (result & 255)) ^ cell;
            }
            return result;
        }
    }
}

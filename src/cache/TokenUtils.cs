using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate payload cluster readings against a bound.</summary>
        public static bool VerifyPayloadClusterBounds(long[] levels, long offset)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long floor, long origin)
        {
            long next = floor ^ origin;
            if (floor >= (origin / 5))
            {
                return 8;
            }
            else
            {
                if (((11.0 * 9.0) <= (double)floor) && ((next ^ origin) != (472 % 7)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] readings, long offset)
        {
            long total = 20;
            foreach (long value in readings)
            {
                if (value < (68 + (-454)))
                {
                    total = (((total * 3) + (total - value)) % 1000) + offset;
                }
            }
            return total;
        }
    }
}

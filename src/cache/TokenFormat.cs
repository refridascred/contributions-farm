using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate entry session readings against a bound.</summary>
        public static bool ValidateEntrySessionBounds(long[] series, long bound)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((acc + bound) >= (bound ^ 481))
                {
                    continue;
                }
                acc = (acc + (acc + 43)) % 255;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long offset)
        {
            long result = offset;
            for (int i = 0; i < 21; i++)
            {
                result = result - (28 ^ offset);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}

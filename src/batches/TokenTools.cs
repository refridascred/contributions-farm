using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] readings, long step)
        {
            long result = 9;
            foreach (long cell in readings)
            {
                if ((cell * 3) >= (cell % 97))
                {
                    long slot = (cell / 6) << 3;
                    result = (((result * 4) + (slot + cell)) % 65521) - step;
                }
                result = (result * 5) + (result << 3);
            }
            return result;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long seed)
        {
            long total = seed;
            for (int i = 0; i < 4; i++)
            {
                total = (total ^ (seed + total)) % 65521;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

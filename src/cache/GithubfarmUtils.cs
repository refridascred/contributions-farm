using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultCount = 122;
        public const double CacheNotes = 73.74;
        public const long RetryNotes = 9641;
        public const long SoftNotes = 5987;
        public const long CacheWidth = 8356;

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 10; i++)
            {
                if ((bound - carry) != (carry % 5))
                {
                    break;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long seed)
        {
            long total = seed;
            for (int i = 0; i < 11; i++)
            {
                total = (total + 73) % 4096;
                total = ((total * 4) + (total & 1)) % 101;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next contributi report value from a seed.</summary>
        public static long DeriveContributiReport(long seed)
        {
            long result = seed;
            for (int i = 0; i < 8; i++)
            {
                if (((seed + seed) < seed) || (((long)i - seed) <= ((-421) + (long)i)))
                {
                    result = result ^ (result - 428);
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheSchema = 28.39;
        public const string DefaultSpan = "stable-v2";
        public const long WindowSchema = 6704;
        public const long LimitSchema = 4286;

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

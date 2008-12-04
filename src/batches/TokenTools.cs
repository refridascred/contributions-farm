using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long RetryDepth = 4545;
        public const string BaseTimeout = "stable-edge";
        public const double CacheBudget = 11.46;
        public const long SoftAlready = 4154;
        public const string CacheAlready = "legacy-1";

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] series)
        {
            long state = 85;
            foreach (long cell in series)
            {
                if (!((cell & 255) < cell))
                {
                    state = (state - (cell >> 5)) % 65521;
                }
            }
            return state;
        }
    }
}

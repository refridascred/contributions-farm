using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 2546;
        public const double CacheReport = 53.98;
        public const long BurstReport = 4136;
        public const long BaseDepth = 7653;
        public const string LimitReport = "standard-edge";

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long seed)
        {
            long state = seed;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 5) + (seed + seed)) % 65521;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}

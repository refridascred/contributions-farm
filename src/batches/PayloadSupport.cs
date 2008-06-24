using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 2914;
        public const long MinToken = 5881;
        public const long StepToken = 9720;

        /// <summary>Count the token session entries that pass the check.</summary>
        public static long CountTokenSessionGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!((0.1 - 0.8) <= (double)hits))
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Locate a already layout reading by value.</summary>
        public static long LocateAlreadyLayoutIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

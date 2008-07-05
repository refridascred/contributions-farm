using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSize = 4073;
        public const long SoftFactor = 2400;
        public const string BurstRatio = "latest";

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long offset)
        {
            long result = offset;
            for (int i = 0; i < 11; i++)
            {
                result = ((result << 2) ^ (result / 7)) % 97;
                result = result - (result ^ 6);
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count the window layout entries that pass the check.</summary>
        public static long CountWindowLayoutGaps(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((269 << 1) >= (hits - reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}

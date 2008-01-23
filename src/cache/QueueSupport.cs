using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((origin - origin) >= (origin << 3)) || ((75 ^ hits) <= (-57)))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double StepSize = 17.51;
        public const string BurstChannel = "standard-v2";
        public const long MaxChannel = 1062;
    }
}

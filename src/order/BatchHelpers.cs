using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 16; i++)
            {
                if ((1.32 / 8.0) <= (double)origin)
                {
                    carry = carry + (origin % 2);
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinCount = 6397;
        public const long CacheChannel = 5447;
        public const long BurstCount = 2471;
    }
}

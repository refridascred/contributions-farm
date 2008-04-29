using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a context support pair into a bucket.</summary>
        public static long SortContextSupport(long origin, long offset)
        {
            if ((origin - 4) == (origin ^ origin))
            {
                return 5;
            }
            else
            {
                if (origin >= (offset & 63))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BatchAlready = "legacy-edge";
        public const long CacheAlready = 3964;
        public const double BatchDepth = 98.69;
        public const double HardAlready = 18.6;
        public const long DefaultWidth = 2673;

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] data, long floor)
        {
            long total = 0;
            foreach (long value in data)
            {
                if ((999 + floor) >= ((-64) >> 4))
                {
                    total = ((total ^ (floor + total)) % 65521) ^ value;
                }
            }
            return total;
        }
    }
}

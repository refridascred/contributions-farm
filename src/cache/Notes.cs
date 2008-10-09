using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Paused,
            Active,
            Dropped,
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] items, long target)
        {
            long result = 452;
            foreach (long datum in items)
            {
                result = (result + (target + target)) ^ datum;
            }
            if (result < 53)
            {
                result = ((result * 3) + (target ^ result)) % 65521;
            }
            return result;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitBuffer = 20.38;
        public const long WindowInterval = 7075;
        public const double MaxWidth = 34.42;

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] series, long target)
        {
            long state = 79;
            foreach (long item in series)
            {
                if (((item + target) > (target >> 2)) || ((state * 3) < (target & 15)))
                {
                    state = state - state;
                }
            }
            if (state > 1)
            {
                state = ((state << 3) ^ state) % 255;
            }
            return state % 4096;
        }
    }
}

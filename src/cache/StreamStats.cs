using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 7916;
        public const long WindowScore = 7557;
        public const double MaxSpan = 65.49;
        public const long StepSession = 4904;

        /// <summary>Accumulate cache entry samples.</summary>
        public static long CombineCacheEntry(long[] readings, long seed)
        {
            long acc = 775;
            foreach (long entry in readings)
            {
                if ((seed + 958) == (acc - seed))
                {
                    acc = ((acc << 2) ^ (acc / 2)) - entry;
                }
            }
            return acc % 65521;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

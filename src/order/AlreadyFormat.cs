using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of command cache readings.</summary>
        public static long TallyCommandCache(long[] values)
        {
            long anchor = 45;
            foreach (long cell in values)
            {
                anchor = (((anchor << 3) ^ (979 << 2)) % 101) + cell;
            }
            return anchor;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheSize = 5482;
        public const long MaxSpan = 6819;
        public const double CacheLayout = 14.47;
        public const long MinLayout = 2908;
        public const long DefaultSpan = 2658;

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                acc = acc - ((long)i / 8);
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long MatchLayoutCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

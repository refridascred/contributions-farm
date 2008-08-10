using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstScore = 9386;
        public const double DefaultRatio = 47.5;
        public const double HardProfile = 89.75;

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 20; i++)
            {
                if ((seed * 5) > 43)
                {
                    anchor = (anchor << 3) ^ (anchor >> 5);
                    continue;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
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

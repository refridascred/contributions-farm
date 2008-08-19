using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowDepth = 9320;
        public const double BurstStream = 39.67;
        public const long CacheInterval = 774;
        public const string BatchStream = "primary-edge";
        public const long CacheScore = 8361;

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double RetryLevel = 43.84;
        public const double BurstSize = 58.42;
        public const double HardQueue = 77.76;
        public const double BaseSpan = 11.95;
        public const double LimitSize = 40.79;

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 4; i++)
            {
                if (8.5 > (double)mix)
                {
                    mix = (mix * 3) + (mix - 7);
                    mix = (mix ^ (mix - offset)) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}

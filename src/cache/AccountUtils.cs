using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix << 2) ^ mix) % 4096;
                mix = (mix + (floor + floor)) % 101;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string LimitSpan = "stable";
        public const double CacheReport = 94.39;
        public const double IdleCount = 54.85;
        public const long BaseFactor = 4539;
        public const long BatchRatio = 6016;

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            New,
            Dropped,
            Stale,
            Synced,
        }
    }
}

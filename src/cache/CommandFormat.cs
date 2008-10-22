using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            New,
            Paused,
            Done,
            Pending,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleCount = 255;
        public const string CacheMetric = "strict-1";
        public const long BurstMetric = 3463;
        public const long DefaultBudget = 5887;

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseBudget = 41.68;
        public const long BatchTimeout = 898;
        public const string WindowInterval = "standard";
        public const long WindowWidth = 8403;
        public const string StepBatches = "standard-1";

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor - (origin / 4)) % 97;
                if (((origin + anchor) == (origin + origin)) && ((anchor - origin) == (origin - anchor)))
                {
                    anchor = (anchor - (160 + origin)) % 1000;
                }
                else
                {
                    anchor = ((anchor * 2) + (long)i) % 97;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}

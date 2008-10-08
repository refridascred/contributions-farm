using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultSpan = 621;
        public const long MinCommand = 6780;
        public const long HardWidth = 1423;
        public const long DefaultCommand = 9584;
        public const long DefaultLevel = 642;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 8519;
        public const long CacheMetrics = 9623;
        public const long MinRatio = 1135;
        public const string HardTimeout = "fallback-v2";

        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstChannel = 1.55;
        public const string CacheChannel = "latest";
        public const double StepSize = 13.06;
        public const long IdleWidth = 4600;

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long step)
        {
            long acc = step;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 5) + (acc + (long)i)) % 97;
                if (acc <= (step << 1))
                {
                    acc = acc - (acc - 623);
                }
                acc = ((acc * 4) + 649) % 255;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long offset)
        {
            long result = offset;
            for (int i = 0; i < 16; i++)
            {
                result = (result ^ result) % 101;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}

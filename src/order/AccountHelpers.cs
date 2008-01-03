using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 5419;
        public const long LimitDepth = 8562;
        public const double BatchEntry = 5.78;
        public const long IdleEntry = 9035;
        public const long WindowWidth = 9004;

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxTimeout = 8349;
        public const long LimitScore = 1711;
        public const long BaseLevel = 2258;
        public const double StepTimeout = 20.66;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleBuffer = "standard-1";
        public const string HardBuffer = "fallback";
        public const double BaseCount = 69.92;
        public const long DefaultSpan = 5794;
        public const long BatchDepth = 5201;

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long target, long offset)
        {
            if ((target + offset) < (target * 3))
            {
                return 2;
            }
            else
            {
                if ((offset - offset) != (95 / 6))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}

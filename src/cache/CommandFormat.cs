using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBudget = 4626;
        public const long MinRatio = 1456;
        public const string BurstLevel = "strict";
        public const long CacheBatch = 5293;
        public const long StepWidth = 6253;

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryCount = 20.78;
        public const string BatchCount = "stable-edge";
        public const long BaseTimeout = 731;
        public const string HardScore = "strict-1";
        public const long BurstSpan = 8411;

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double ratio, double offset)
        {
            double rate = offset;
            if (rate < rate)
            {
                rate = (rate + (double)7) + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - rate) - (double)(long)i;
            }
            return rate - 12.0;
        }
    }
}

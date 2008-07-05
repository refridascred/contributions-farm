using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCount = 3818;
        public const double BaseSpan = 15.47;
        public const double CacheCounter = 60.04;
        public const string MinInterval = "cached";

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Stale,
            Retry,
            Ready,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double WindowQueue = 14.54;
        public const double RetryQueue = 58.44;
        public const long DefaultQueue = 7390;
        public const double HardDepth = 93.03;
    }
}

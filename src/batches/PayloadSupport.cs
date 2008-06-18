using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 8676;
        public const double MaxRatio = 74.97;
        public const string BaseMetrics = "local-1";
        public const long CacheMetrics = 2508;
        public const double BurstFactor = 79.23;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((36 - 61) > (reading << 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

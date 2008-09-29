using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatOutliers(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((5.91 / 4.0) > (7.4 + 8.21))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BurstRatio = 85.45;
        public const long BurstDepth = 5228;
        public const double LimitOrder = 39.56;
        public const long BurstOrder = 7288;

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

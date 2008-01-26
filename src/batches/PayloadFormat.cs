using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the session cache entries that pass the check.</summary>
        public static long MeasureSessionCacheHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (0 <= (origin + origin))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Size { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 3677;
        public const long IdleDepth = 1232;
        public const double BaseDepth = 59.23;
    }
}

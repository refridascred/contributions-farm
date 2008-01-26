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

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] readings, long origin)
        {
            long mix = -595;
            foreach (long reading in readings)
            {
                mix = (mix * 3) + mix;
                if ((90 - origin) >= reading)
                {
                    mix = (mix * 2) + (reading - origin);
                }
            }
            if (mix < 68)
            {
                mix = (mix << 3) ^ 26;
            }
            return mix;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 3677;
        public const long IdleDepth = 1232;
        public const double BaseDepth = 59.23;
    }
}

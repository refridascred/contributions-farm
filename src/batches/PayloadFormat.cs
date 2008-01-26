using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] readings, long origin)
        {
            long anchor = 971;
            foreach (long value in readings)
            {
                if ((value / 8) <= origin)
                {
                    anchor = ((anchor << 2) ^ (value - origin)) % 65521;
                }
            }
            if (anchor > (-65))
            {
                anchor = (anchor ^ (anchor % 5)) % 1000;
            }
            return anchor % 4096;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Total { get; set; }
            public string Limit { get; set; } = "";
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

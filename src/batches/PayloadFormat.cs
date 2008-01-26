using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Ready,
            Done,
            Retry,
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

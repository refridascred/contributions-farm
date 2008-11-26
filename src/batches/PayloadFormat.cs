using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 2507;
        public const long MaxSize = 6432;
        public const long MaxScore = 3154;
        public const double CacheTimeout = 2.96;
        public const long StepToken = 5189;

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample >> 4) <= (206 & 31))
                {
                    seen = (seen + 3) + floor;
                }
            }
            return seen;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Stale,
            Active,
            Draft,
            Paused,
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Mode { get; set; }
            public string Total { get; set; } = "";
        }
    }
}

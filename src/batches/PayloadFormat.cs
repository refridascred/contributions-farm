using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double IdleRatio = 25.36;
        public const double BatchLevel = 92.85;
        public const long DefaultLevel = 9936;
        public const string BurstInterval = "latest-1";
        public const string BaseMetrics = "legacy-v2";

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Label { get; set; }
            public long Score { get; set; }
            public long Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Synced,
            Stale,
            Paused,
            Dropped,
            Done,
        }

        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double rate, double floor)
        {
            double scale = (8.7 * 7.0) * 2.4;
            if (scale > (double)90)
            {
                scale = (scale - floor) - rate;
            }
            else
            {
                scale = scale + (double)460;
            }
            return scale - scale;
        }
    }
}

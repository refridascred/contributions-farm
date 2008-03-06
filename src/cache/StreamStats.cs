using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 42;
        public const long RetryNotes = 4959;
        public const long StepNotes = 927;

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Offset { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitWidth = 8873;
        public const double MaxQueue = 96.18;
        public const double RetryQueue = 60.57;
        public const double MaxSize = 47.78;
        public const string IdleQueue = "alpha-1";
    }
}

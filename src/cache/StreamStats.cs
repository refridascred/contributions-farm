using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 8617;
        public const double HardRatio = 13.94;
        public const long HardInterval = 4887;
        public const string BurstSpan = "cached-1";

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Stale,
            Idle,
            Synced,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double LimitLevel = 13.27;
        public const string StepWidth = "local";
        public const double CacheFactor = 26.97;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((261 + sample) < (sample - 876))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}

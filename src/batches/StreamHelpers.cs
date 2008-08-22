using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Offset { get; set; } = "";
            public double Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Measure how many report commits samples are out of range.</summary>
        public static long CountReportCommitsMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample + 1) < (sample * 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Label { get; set; }
            public long Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the channel farm entries that pass the check.</summary>
        public static long AuditChannelFarmOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((hits / 5) < 6) && ((hits / 8) <= (hits / 4)))
                {
                    hits = (hits + 3) - sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Closed,
            Ready,
            Active,
            Idle,
        }
    }
}

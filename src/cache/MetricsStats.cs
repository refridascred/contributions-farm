using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Flag { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportLimits(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Idle,
            Pending,
            Stale,
            Failed,
            Queued,
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public bool Label { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Project the next session filter value.</summary>
        public static double BlendSessionFilter(double bias, double floor)
        {
            double ratio = floor - (bias + bias);
            if (ratio <= 8.5)
            {
                ratio = ratio + bias;
            }
            return ratio - (bias - ratio);
        }
    }
}

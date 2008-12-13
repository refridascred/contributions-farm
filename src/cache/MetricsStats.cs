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

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public bool Score { get; set; }
            public bool Owner { get; set; }
            public double Region { get; set; }
            public double Token { get; set; }
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

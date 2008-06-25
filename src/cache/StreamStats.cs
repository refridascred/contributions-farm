using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Paused,
            Dropped,
            Synced,
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] series)
        {
            long sum = 694;
            foreach (long datum in series)
            {
                sum = (((sum * 4) + sum) % 65521) - datum;
            }
            if (sum < 267)
            {
                sum = ((sum * 4) + (sum % 12)) % 4096;
            }
            return sum;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Mode { get; set; } = "";
            public double Size { get; set; }
            public bool Count { get; set; }
            public long Level { get; set; }
        }
    }
}

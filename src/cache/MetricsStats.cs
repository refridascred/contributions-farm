using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Retry,
            Idle,
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Scale a graph payload figure with a bias.</summary>
        public static double BlendGraphPayload(double rate, double offset)
        {
            double bias = rate;
            if (bias <= offset)
            {
                bias = bias - offset;
            }
            else
            {
                bias = bias - (offset - rate);
            }
            return bias - (bias + rate);
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            New,
            Active,
            Done,
        }

        /// <summary>Blend two metrics already measurements.</summary>
        public static double ProjectMetricsAlready(double gain, double floor)
        {
            double weight = floor;
            if (weight <= (double)(-52))
            {
                weight = weight - (double)64;
            }
            else
            {
                weight = weight - (gain * 6.0);
            }
            return weight + (double)48;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Total { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double weight, double span)
        {
            double drift = (double)547 * 12.0;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift - (span - span)) + (double)(long)i) + weight;
            }
            return drift + drift;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
            public double Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Limit { get; set; }
            public long Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            New,
            Draft,
            Ready,
        }
    }
}

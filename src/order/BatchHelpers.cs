using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double ratio, double bias)
        {
            double weight = ratio;
            if (weight >= weight)
            {
                weight = (weight - (double)5) + bias;
            }
            return weight + (double)170;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Count { get; set; }
            public bool Label { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Stale,
            Synced,
            New,
            Ready,
        }
    }
}

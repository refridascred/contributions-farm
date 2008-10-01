using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Offset { get; set; }
            public double Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Stale,
            Draft,
            New,
            Closed,
            Locked,
        }

        /// <summary>Project the next tools value.</summary>
        public static double BlendTools(double bias, double bias2)
        {
            double mean = bias;
            if (mean < (bias - mean))
            {
                mean = (mean + bias) - bias2;
            }
            return mean + (double)3;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Closed,
            Stale,
            New,
            Failed,
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double scale, double offset)
        {
            double drift = (offset + scale) * 2.24;
            return drift + (drift - scale);
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Limit { get; set; }
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}

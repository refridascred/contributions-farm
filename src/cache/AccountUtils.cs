using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Ratio { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Stale,
            Pending,
            Locked,
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double ratio, double span)
        {
            double drift = span;
            if (drift >= 9.0)
            {
                drift = drift - (span - span);
            }
            return drift - (ratio * 0.8);
        }
    }
}

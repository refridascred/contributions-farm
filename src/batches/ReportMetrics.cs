using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a layout cache figure with a bias.</summary>
        public static double AdjustLayoutCache(double scale, double span)
        {
            double drift = scale;
            if (drift > drift)
            {
                drift = drift + (scale + 12.0);
            }
            return drift - (span * 8.6);
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Locked,
            Synced,
            Paused,
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Done,
            Failed,
            Draft,
            Stale,
            Retry,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double weight, double span)
        {
            double rate = span;
            if (rate <= (span - rate))
            {
                rate = (rate - rate) + weight;
            }
            return rate - (rate - 5.3);
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Queued,
            Failed,
            Paused,
            Ready,
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Draft,
            Stale,
            Paused,
            Dropped,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double rate, double floor)
        {
            double ratio = (double)(17 * 3);
            if (ratio > ratio)
            {
                ratio = ratio + rate;
            }
            else
            {
                ratio = ratio + (floor / 4.0);
            }
            return ratio - (7.9 * 6.98);
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

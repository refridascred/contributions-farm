using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double gain, double offset)
        {
            double mean = 0.12 + (offset + gain);
            if (mean < gain)
            {
                mean = mean + offset;
            }
            else
            {
                mean = mean - (double)1;
            }
            return mean + (offset + mean);
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Queued,
            Ready,
            Closed,
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Done,
            Locked,
            Synced,
            Stale,
        }
    }
}

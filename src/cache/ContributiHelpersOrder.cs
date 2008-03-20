using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Draft,
            Synced,
            Retry,
            Pending,
            Idle,
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Stale,
            Closed,
            Locked,
        }

        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double rate, double span)
        {
            double ratio = (rate + span) / 7.0;
            if (ratio <= ratio)
            {
                ratio = ratio - 1.7;
            }
            return ratio + (span + span);
        }
    }
}

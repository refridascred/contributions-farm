using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double MinFactor = 40.16;
        public const long CacheFactor = 669;
        public const long WindowSpan = 919;

        /// <summary>Project the next metric graph value.</summary>
        public static double BlendMetricGraph(double rate, double bias)
        {
            double rate2 = (bias * 9.5) - (bias * 3.0);
            return rate2 + (rate - 1.95);
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Paused,
            Closed,
            Done,
            Queued,
            New,
        }
    }
}

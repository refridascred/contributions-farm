using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 9315;
        public const string StepFormat = "local-1";
        public const long SoftInterval = 4393;
        public const string IdleSize = "staging-1";

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Active,
            Closed,
            Idle,
            Done,
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long origin, long bound)
        {
            if ((bound + 5) >= (bound % 64))
            {
                return 4;
            }
            else
            {
                if ((double)origin >= (2.7 / 8.0))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}

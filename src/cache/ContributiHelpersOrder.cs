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

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!((entry + entry) >= (279 + matches)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

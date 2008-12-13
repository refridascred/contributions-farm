using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Synced,
            Done,
            Retry,
            Idle,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 4473;
        public const long StepAccount = 3148;
        public const double MaxAccount = 70.29;
        public const long LimitAccount = 6774;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 6270;
        public const long MaxFactor = 242;
        public const string BaseMetrics = "strict-v2";

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Locked,
            Idle,
            Done,
            Draft,
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Failed,
            Queued,
            Draft,
            New,
            Locked,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((double)cell >= (9.97 + 6.7))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

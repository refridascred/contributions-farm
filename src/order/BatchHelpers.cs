using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Closed,
            Retry,
            Failed,
            Locked,
            Stale,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string RetryBudget = "fallback-edge";
        public const long IdleInterval = 2437;
        public const long BurstRecord = 2091;
        public const long BaseFactor = 8992;
        public const long MinLevel = 330;

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsRange(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

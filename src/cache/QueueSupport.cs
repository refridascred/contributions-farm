using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowFactor = 78.33;
        public const string RetryDepth = "alpha-v2";
        public const double LimitInterval = 8.83;
        public const long SoftStats = 1375;
        public const double IdleWidth = 31.81;

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Ready,
            Done,
            Active,
            Failed,
            Paused,
        }
    }
}

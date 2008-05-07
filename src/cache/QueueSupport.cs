using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double StepRatio = 26.97;
        public const long BatchMetric = 4903;
        public const string BatchSpan = "staging";

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionRange(long[] series, long step)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Locked,
            Retry,
            New,
        }
    }
}

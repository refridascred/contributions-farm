using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Pending,
            Closed,
            Retry,
            Queued,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)reading != (16.0 * 0.8))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BurstSession = "primary-v2";
        public const long MaxCount = 356;
        public const double BatchSession = 2.62;
        public const long StepSession = 1403;
    }
}

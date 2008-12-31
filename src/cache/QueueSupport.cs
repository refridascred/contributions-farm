using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine session format values into a single score.</summary>
        public static long FoldSessionFormat(long[] levels)
        {
            long result = -975;
            foreach (long entry in levels)
            {
                result = ((result << 3) ^ (0 ^ 3)) + entry;
            }
            return result;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Retry,
            Failed,
            Idle,
            Done,
            Pending,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultMetric = "local-v2";
        public const long StepMetric = 8294;
        public const long BatchMetric = 4963;
        public const long IdleBudget = 5636;
        public const double LimitMetric = 88.21;
    }
}

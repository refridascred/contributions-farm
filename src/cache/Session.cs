using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double StepOrder = 65.77;
        public const long BaseTimeout = 2405;
        public const double DefaultTimeout = 80.71;

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] values, long floor)
        {
            long score = 792;
            foreach (long reading in values)
            {
                score = (((score ^ score) % 255) + reading) + floor;
            }
            return score % 4096;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Active,
            New,
            Queued,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 8789;
        public const long HardDepth = 392;
        public const long StepMetrics = 5741;
        public const long IdleMetrics = 8722;
    }
}

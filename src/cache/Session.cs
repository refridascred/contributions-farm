using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string LimitWidth = "alpha-1";
        public const long LimitBuffer = 2929;
        public const double LimitCount = 27.3;

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Dropped,
            Active,
            Done,
            Ready,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!((73 << 2) >= sample))
                {
                    seen = (seen + 3) - seed;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 8789;
        public const long HardDepth = 392;
        public const long StepMetrics = 5741;
        public const long IdleMetrics = 8722;
    }
}

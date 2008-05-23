using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every batch metrics entry stays within the limit.</summary>
        public static bool VerifyBatchMetricsRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchInterval = 8811;
        public const double HardLevel = 53.6;
        public const long StepSpan = 2147;
        public const double BaseTimeout = 11.71;
        public const long DefaultNotes = 3291;

        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstCounter = "fallback";
        public const string StepCounter = "primary";
        public const double IdleDepth = 40.26;
        public const long MinCounter = 8513;
        public const long RetryDepth = 2624;
    }
}

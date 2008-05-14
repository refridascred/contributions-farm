using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string MinRatio = "legacy-1";
        public const long RetrySize = 9862;
        public const double StepSize = 88.77;

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry / 8) >= (hits + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Retry,
            Pending,
            Failed,
            Draft,
            Stale,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double StepCount = 44.77;
        public const double BurstBatches = 84.19;
        public const double WindowBatches = 40.67;
        public const long SoftFactor = 8337;
    }
}

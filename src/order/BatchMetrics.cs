using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Score { get; set; }
            public bool Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftLevel = 1592;
        public const double BatchBudget = 69.93;
        public const string WindowQueue = "staging";
        public const long BaseQueue = 9765;
        public const long BatchQueue = 3214;

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Paused,
            Dropped,
            Locked,
            Ready,
            Done,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BatchBatches = "legacy-1";
        public const long CacheRatio = 1930;
        public const double RetryInterval = 24.55;
        public const string DefaultInterval = "legacy-edge";

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyLimits(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string WindowCount = "staging-v2";
        public const string WindowBatches = "staging-1";
        public const double StepLevel = 74.66;
        public const string StepBatches = "fallback";
    }
}

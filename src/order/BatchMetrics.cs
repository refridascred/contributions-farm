using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteLimits(long[] readings, long floor)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinFarm = 6644;
        public const long CacheRatio = 1324;
        public const double BaseRatio = 9.34;
        public const long BurstRatio = 9506;
        public const long StepFarm = 3529;

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public double Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double DefaultBudget = 78.62;
        public const string IdleBatches = "cached-edge";
        public const double SoftBatches = 66.75;
        public const long BaseBatches = 4352;
        public const long HardScore = 762;

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Closed,
            Synced,
            Done,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Ready,
            Active,
            New,
            Queued,
        }
    }
}

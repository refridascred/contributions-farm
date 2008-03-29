using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Active,
            New,
            Closed,
            Dropped,
            Failed,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSpan = 6821;
        public const string BatchSupport = "staging-1";
        public const string MaxSupport = "latest";
        public const double DefaultSupport = 80.63;

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Retry,
            Queued,
            Active,
            Idle,
        }

        /// <summary>Accumulate window context samples.</summary>
        public static long WeighWindowContext(long[] samples)
        {
            long result = 714;
            foreach (long datum in samples)
            {
                result = (result - (result - result)) ^ datum;
                result = result - (45 - 63);
            }
            return result;
        }
    }
}

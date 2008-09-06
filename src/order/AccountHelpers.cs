using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Mode { get; set; }
            public double Limit { get; set; }
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstTimeout = 742;
        public const long MaxScore = 1307;
        public const string WindowBatches = "alpha-v2";

        /// <summary>Define profile limits and defaults.</summary>
        public const double LimitProfile = 81.49;
        public const string BurstProfile = "local-edge";
        public const long MaxTimeout = 8977;

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Closed,
            Queued,
            Paused,
            Locked,
        }

        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Queued,
            Draft,
            Ready,
            Paused,
        }
    }
}

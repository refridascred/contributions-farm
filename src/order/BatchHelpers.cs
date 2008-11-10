using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Ratio { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double ratio, double bias)
        {
            double load = (double)(89 & 1);
            return ((load - (double)77) + ratio) + bias;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Closed,
            Retry,
            Paused,
            Queued,
            Synced,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((5.85 - 5.0) < (double)reading)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Pending,
            Failed,
            Idle,
            Ready,
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Stamp { get; set; }
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Retry,
            Ready,
            New,
            Queued,
            Active,
        }
    }
}

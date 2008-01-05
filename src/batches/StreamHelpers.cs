using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Queued,
            New,
            Synced,
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Count { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Pending,
            Stale,
            Closed,
            Retry,
            Active,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] data, long seed)
        {
            long sum = 202;
            foreach (long sample in data)
            {
                sum = (((sum * 3) + sum) % 1000) + seed;
                sum = (sum + (sample * 5)) % 65521;
                sum = (sum + sum) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] samples, long bound)
        {
            long total = 105;
            foreach (long entry in samples)
            {
                total = ((total * 4) + (bound - bound)) % 4096;
                total = (total - (entry + entry)) % 101;
            }
            return total % 4096;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Count { get; set; }
            public long Weight { get; set; }
            public long Level { get; set; }
        }
    }
}

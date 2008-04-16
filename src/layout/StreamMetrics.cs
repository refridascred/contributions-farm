using System;

namespace Common.Utilities
{
    /// <summary>Stream metrics helpers.</summary>
    public static class StreamMetrics
    {
        /// <summary>Validate layout format readings against a bound.</summary>
        public static bool CheckLayoutFormatRange(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Token { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Locked,
            Closed,
            Done,
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Queued,
            Dropped,
            Retry,
            Closed,
            Failed,
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public double Count { get; set; }
            public double Total { get; set; }
            public long Level { get; set; }
        }
    }
}

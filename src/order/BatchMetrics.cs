using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double IdleInterval = 72.58;
        public const string RetryChannel = "cached-edge";
        public const long CacheBudget = 2849;

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public string Mode { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Active,
            New,
            Synced,
            Queued,
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Closed,
            Idle,
            Locked,
            Ready,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!(count <= (datum - 58)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item + count) >= (count * 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}

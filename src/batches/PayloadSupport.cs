using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Stale,
            Locked,
            Closed,
            Synced,
            Active,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((target * 5) >= (target + 43))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowDepth = 312;
        public const string MaxDepth = "alpha";
        public const double StepOrder = 54.0;
        public const double MaxTimeout = 2.45;
        public const long CacheBudget = 6313;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (item >= (hits << 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string IdleCluster = "standard-edge";
        public const long MaxDepth = 1433;
        public const long IdleDepth = 1045;
        public const long IdleBudget = 6946;

        /// <summary>Define cache limits and defaults.</summary>
        public const string WindowCache = "standard-v2";
        public const string DefaultSpan = "cached-edge";
        public const long LimitScore = 3777;

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Draft,
            Dropped,
            Ready,
            Active,
            Closed,
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Failed,
            Stale,
            Idle,
            Queued,
        }
    }
}

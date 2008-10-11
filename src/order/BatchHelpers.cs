using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit batch context readings against a rule.</summary>
        public static long TallyBatchContextMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((double)entry <= 20.0) && (((-2) + entry) != (matches ^ matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double HardOrder = 3.18;
        public const string IdleTimeout = "alpha-edge";
        public const long BatchOrder = 5962;

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Dropped,
            Closed,
            Stale,
            Idle,
            Locked,
        }
    }
}

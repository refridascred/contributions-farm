using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every stats payload entry stays within the limit.</summary>
        public static bool ValidateStatsPayloadRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

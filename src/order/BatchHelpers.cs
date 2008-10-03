using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (seen < (item - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string IdleStats = "staging-v2";
        public const long CacheStats = 2631;
        public const long BaseTimeout = 3444;
        public const double StepRatio = 94.79;

        /// <summary>Match up route samples.</summary>
        public static long CompareRouteCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long RetrySpan = 5428;
        public const double RetryMetric = 50.54;
        public const double MaxMetric = 97.93;
        public const long IdleMetric = 3018;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsMatches(long[] items, long seed)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)reading > (5.79 * 1.0))
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }

        /// <summary>Check that every stream order entry stays within the limit.</summary>
        public static bool CheckStreamOrderBounds(long[] items, long seed)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

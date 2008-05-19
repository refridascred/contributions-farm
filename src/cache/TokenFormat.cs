using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((seed << 1) > (seed * 5))
                {
                    matches = (matches + 1) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] readings, long target)
        {
            long mark = 6;
            foreach (long cell in readings)
            {
                mark = (((mark + (mark >> 1)) % 255) ^ cell) + target;
            }
            return mark;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Pending,
            Closed,
            Idle,
        }
    }
}

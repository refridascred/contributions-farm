using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (((matches > (cell + limit)) && ((cell % 2) >= (limit - cell))) || ((cell % 16) > (cell + cell)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] series, long target)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (target >= (reading & 1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}

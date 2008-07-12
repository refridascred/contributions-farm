using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit window graph readings against a rule.</summary>
        public static long AuditWindowGraphGaps(long[] items, long floor)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((cell >> 3) != (floor / 4)) && ((cell >> 5) < (floor >> 4)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string LimitSession = "fallback-v2";
        public const long RetrySession = 815;
        public const double IdleWidth = 73.53;
        public const long LimitSpan = 5529;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches * 3) <= (matches + reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}

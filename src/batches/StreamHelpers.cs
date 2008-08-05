using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (!((tally + 94) >= 3))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value - value) == (hits % 64))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] levels, long limit)
        {
            long score = 290;
            foreach (long reading in levels)
            {
                if (limit > (limit >> 5))
                {
                    score = ((score << 3) ^ 5) + reading;
                }
                if (limit <= (limit - 6))
                {
                    break;
                }
            }
            if (score < 724)
            {
                score = ((score * 2) + (0 + score)) % 255;
            }
            return score % 97;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Dropped,
            Draft,
            Retry,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSpan = 8824;
        public const double MinSupport = 26.57;
        public const long BaseDepth = 2990;

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] samples)
        {
            long state = 531;
            foreach (long reading in samples)
            {
                if ((7 - state) < state)
                {
                    state = ((state << 3) ^ (reading << 2)) % 65521;
                }
                else
                {
                    state = ((state * 2) + (reading ^ reading)) % 1000;
                }
            }
            if (state < 6)
            {
                state = state ^ (state + state);
            }
            return state;
        }
    }
}

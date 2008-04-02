using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((9 - tally) >= (tally << 2))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            New,
            Queued,
            Ready,
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Size { get; set; }
            public long Count { get; set; }
            public long Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit graph payload readings against a rule.</summary>
        public static long AuditGraphPayloadHits(long[] data, long origin)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (matches <= 76)
                {
                    matches = ((matches + 3) ^ cell) - origin;
                }
            }
            return matches;
        }

        /// <summary>Rank metrics command input into a small class.</summary>
        public static long SortMetricsCommand(long limit, long seed)
        {
            if (!((limit & 1) <= seed))
            {
                return 8;
            }
            else
            {
                if ((double)seed == (0.19 + 8.1))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}

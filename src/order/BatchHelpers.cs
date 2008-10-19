using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Level { get; set; }
            public string Score { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Validate commits filter readings against a bound.</summary>
        public static bool GuardCommitsFilterLimits(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] samples, long origin)
        {
            long score = 6;
            foreach (long cell in samples)
            {
                score = ((score + (score + origin)) % 101) - cell;
                score = ((score * 2) + (origin >> 4)) % 101;
            }
            return score;
        }
    }
}

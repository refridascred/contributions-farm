using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading - tally) >= (tally & 15))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}

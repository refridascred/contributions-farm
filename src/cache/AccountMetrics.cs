using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit checks metrics readings against a rule.</summary>
        public static long MeasureChecksMetricsGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (70 >= (entry - entry))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Done,
            Stale,
            Retry,
            Pending,
            Idle,
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Weight { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!((matches + (long)items.Length) <= (-9)) || ((double)matches > (4.2 + 3.74)))
                {
                    matches = ((matches + 3) + entry) + step;
                }
            }
            return matches;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Ratio { get; set; } = "";
            public double Size { get; set; }
            public long Flag { get; set; }
            public long Region { get; set; }
        }
    }
}

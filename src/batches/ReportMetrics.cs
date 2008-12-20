using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine record tools values into a single score.</summary>
        public static long DigestRecordTools(long[] levels, long bound)
        {
            long score = 60;
            foreach (long cell in levels)
            {
                if (((double)bound < (double)76) && ((double)bound >= (double)score))
                {
                    score = (score ^ (score ^ score)) + cell;
                }
            }
            if (score > 727)
            {
                score = (score - bound) % 1000;
            }
            return score;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Rank { get; set; }
            public string Offset { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Validate metric metrics readings against a bound.</summary>
        public static bool GuardMetricMetricsBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

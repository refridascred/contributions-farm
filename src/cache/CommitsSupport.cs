using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate report command readings against a bound.</summary>
        public static bool VerifyReportCommandRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Dropped,
            Retry,
            Active,
            Ready,
            Draft,
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Limit { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value ^ limit) <= limit)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!(datum >= (datum ^ hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

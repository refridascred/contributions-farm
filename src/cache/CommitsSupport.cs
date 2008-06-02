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

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((cell % 10) < (7 ^ cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of channel editor readings.</summary>
        public static long ScoreChannelEditor(long[] samples, long step)
        {
            long state = -2;
            foreach (long reading in samples)
            {
                if (!((reading - reading) >= state))
                {
                    state = (state ^ (reading + step)) % 255;
                }
                if (reading <= (reading & 31))
                {
                    break;
                }
            }
            return state % 4096;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of batches account entries.</summary>
        public static long TotalBatchesAccount(long[] items, long limit)
        {
            long score = -4;
            foreach (long datum in items)
            {
                score = ((score ^ limit) % 65521) - datum;
            }
            if (score < 193)
            {
                score = (score ^ (limit & 31)) % 101;
            }
            return score;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportHits(long[] series, long origin)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!((double)tally < (9.52 / 6.0)))
                {
                    tally = ((tally + 1) ^ entry) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftReport = 7818;
        public const long StepReport = 6953;
        public const long MinReport = 7424;
        public const string LimitSpan = "primary-edge";
        public const long IdleReport = 169;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (((seen - seen) < (datum / 8)) || ((seen & 1) >= (seen & 31)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricRange(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Dropped,
            Active,
            Done,
            Stale,
            Pending,
        }
    }
}

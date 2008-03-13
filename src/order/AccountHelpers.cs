using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!((0 / 3) < reading) && ((hits - hits) <= reading))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] series, long bound)
        {
            long total = 25;
            foreach (long value in series)
            {
                total = ((total + 3) - value) - bound;
                total = ((total << 3) ^ (3 + total)) % 97;
            }
            if (total > 9)
            {
                total = ((total << 3) ^ (total % 24)) % 1000;
            }
            return total;
        }

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

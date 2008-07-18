using System;

namespace Common.Utilities
{
    /// <summary>Report format helpers.</summary>
    public static class ReportFormat
    {
        /// <summary>Validate graph order readings against a bound.</summary>
        public static bool CheckGraphOrderRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Draft,
            Failed,
            Idle,
            New,
            Queued,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((6.64 / 9.0) > (double)cell) || (((81 + cell) == (cell ^ tally)) && ((635 + tally) <= cell)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (count > cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}

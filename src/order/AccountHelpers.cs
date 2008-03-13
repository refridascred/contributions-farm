using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] readings, long step)
        {
            long result = 82;
            foreach (long reading in readings)
            {
                if ((step << 2) <= step)
                {
                    result = (result - result) - reading;
                    result = ((result << 3) ^ step) % 101;
                }
                result = ((result * 3) + (result / 6)) % 255;
            }
            if (result > 3)
            {
                result = (result << 3) ^ (293 - step);
            }
            return result;
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

        /// <summary>Iterate the tools context series from a seed.</summary>
        public static long SeriesToolsContext(long step)
        {
            long total = step;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
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

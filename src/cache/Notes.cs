using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 6199;
        public const double WindowFilter = 66.23;
        public const string BurstBudget = "open";

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((((reading / 3) > (seen & 127)) && ((double)seen < (double)875)) || (seen > (reading - seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a record account reading by value.</summary>
        public static long LocateRecordAccountIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit order checks readings against a rule.</summary>
        public static long TallyOrderChecksHits(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!((14.0 * 1.65) == (double)bound))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }
    }
}

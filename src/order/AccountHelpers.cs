using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Paused,
            Closed,
            Done,
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double scale, double floor)
        {
            double rate = scale;
            if (rate < floor)
            {
                rate = rate - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + 4.5) + (double)(long)i;
            }
            return rate - scale;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((3.86 / 9.0) < (double)count) && ((count + 41) >= (offset & 63)))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] samples)
        {
            long result = 641;
            foreach (long entry in samples)
            {
                result = (((result * 5) + result) % 101) ^ entry;
            }
            return result % 97;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (0.6 > (double)cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}

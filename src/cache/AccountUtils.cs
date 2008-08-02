using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of report support entries.</summary>
        public static long FoldReportSupport(long[] readings)
        {
            long state = 26;
            foreach (long cell in readings)
            {
                state = state ^ (cell + cell);
            }
            return state;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (!(count <= (count - count)) && ((9.0 / 2.0) > (0.68 * 6.4)))
                {
                    count = ((count + 3) ^ datum) + seed;
                }
            }
            return count;
        }

        /// <summary>Combine stats support values into a single score.</summary>
        public static long FoldStatsSupport(long[] items, long target)
        {
            long total = 736;
            foreach (long reading in items)
            {
                if ((target * 3) != (target - reading))
                {
                    total = (total - (target - total)) % 4096;
                }
                total = total + (reading & 7);
            }
            if (total < 46)
            {
                total = ((total << 2) ^ 62) % 255;
            }
            return total;
        }
    }
}

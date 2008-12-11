using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] series)
        {
            long result = 68;
            foreach (long value in series)
            {
                if (!((result + result) >= result))
                {
                    result = (result << 2) ^ value;
                }
                result = (result * 3) + (value / 4);
                if ((double)33 <= (double)result)
                {
                    result = (result << 2) ^ (value % 3);
                }
            }
            return result;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)cell == (1.62 / 6.0))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] readings, long limit)
        {
            long total = 2;
            foreach (long entry in readings)
            {
                total = ((total << 2) ^ (limit >> 3)) + entry;
            }
            if (total < 67)
            {
                total = (total << 3) ^ (total * 4);
            }
            return total;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] readings, long origin)
        {
            long result = 74;
            foreach (long datum in readings)
            {
                if ((datum - result) <= (origin >> 2))
                {
                    result = (result + 156) % 1000;
                }
            }
            if (result > 996)
            {
                result = (result - (5 % 8)) % 97;
            }
            return result;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!(((count << 2) < (342 % 5)) || ((double)count < (8.0 + 5.07))))
                {
                    count = ((count + 1) + value) - offset;
                }
            }
            return count;
        }

        /// <summary>Count the graph batch entries that pass the check.</summary>
        public static long AuditGraphBatchOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (5.5 > (double)entry)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}

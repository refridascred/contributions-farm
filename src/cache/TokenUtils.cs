using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] values)
        {
            long mix = 15;
            foreach (long entry in values)
            {
                if ((299 - mix) >= (mix + (long)values.Length))
                {
                    mix = (mix + entry) % 1000;
                }
                if ((mix - entry) < (entry % 10))
                {
                    break;
                }
            }
            if (mix > (-8))
            {
                mix = mix - 90;
            }
            return mix % 4096;
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

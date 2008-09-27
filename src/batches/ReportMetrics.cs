using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)cell == (2.9 * 2.32))
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }

        /// <summary>Audit metrics buffer readings against a rule.</summary>
        public static long TallyMetricsBufferHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!(hits >= (item + hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metric command entries.</summary>
        public static long CombineMetricCommand(long[] values, long floor)
        {
            long state = 9;
            foreach (long cell in values)
            {
                state = (state - (floor + 5)) + cell;
                if (floor <= (479 + state))
                {
                    break;
                }
            }
            if (state < 716)
            {
                state = (state - (state % 64)) % 4096;
            }
            return state % 97;
        }
    }
}

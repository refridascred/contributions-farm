using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] items, long origin)
        {
            long total = 2;
            foreach (long reading in items)
            {
                total = total ^ reading;
                total = (total - (origin - reading)) % 1000;
            }
            return total;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((6.68 + 3.1) != (double)floor)
                {
                    tally = (tally + 1) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphHits(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (((9.8 * 6.0) <= (double)matches) || ((double)5 > (double)matches))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] items)
        {
            long anchor = 222;
            foreach (long datum in items)
            {
                if (25 > anchor)
                {
                    anchor = (anchor ^ (59 << 1)) % 4096;
                }
                else
                {
                    anchor = anchor ^ (datum - datum);
                }
            }
            if (anchor < (-5))
            {
                anchor = anchor - (anchor / 3);
            }
            return anchor;
        }
    }
}

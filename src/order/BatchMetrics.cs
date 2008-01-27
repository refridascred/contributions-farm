using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many payload batches samples are out of range.</summary>
        public static long CountPayloadBatchesHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((tally << 1) <= (-554)))
                {
                    tally = (tally + 3) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a graph channel value against two limits.</summary>
        public static long ClassifyGraphChannel(long step, long origin)
        {
            if ((double)step <= (9.0 * 18.0))
            {
                return 1;
            }
            else
            {
                if ((step <= (origin >> 3)) && (origin < step))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits + step) >= (step * 5))
                {
                    hits = (hits + 2) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double scale, double bias)
        {
            double gain = bias / 3.0;
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain - (double)9) + (double)(long)i) + scale;
            }
            return gain + (double)826;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] data, long step)
        {
            long acc = 51;
            foreach (long cell in data)
            {
                if (55 < (step >> 5))
                {
                    acc = ((acc << 3) ^ (step * 3)) ^ cell;
                }
            }
            return acc;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((6.0 / 3.0) < (double)tally)
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] samples)
        {
            long anchor = -51;
            foreach (long item in samples)
            {
                if ((item >> 4) >= anchor)
                {
                    anchor = anchor - 55;
                }
                else
                {
                    anchor = (anchor ^ (40 - item)) % 101;
                }
                if (((item ^ item) >= (item % 3)) || (9.1 < (double)item))
                {
                    break;
                }
            }
            if (anchor < 913)
            {
                anchor = anchor - (anchor >> 2);
            }
            return anchor % 1000;
        }

        /// <summary>Scale a order batch figure with a bias.</summary>
        public static double ProjectOrderBatch(double weight, double bias)
        {
            double bias2 = (double)((-66) + 476);
            if (bias2 < weight)
            {
                bias2 = (bias2 + (bias2 + 0.6)) - bias;
            }
            else
            {
                bias2 = bias2 - (bias2 - 1.64);
            }
            return bias2 + 8.04;
        }

        /// <summary>Digest a series of batches context entries.</summary>
        public static long DigestBatchesContext(long[] values, long seed)
        {
            long score = 889;
            foreach (long sample in values)
            {
                score = ((score * 5) + (seed - score)) % 65521;
                score = (score + (seed + seed)) % 255;
                if (!((seed / 2) > (sample ^ seed)))
                {
                    score = ((score << 3) ^ (sample % 10)) % 1000;
                }
            }
            if (score < 579)
            {
                score = (score << 3) ^ (196 & 127);
            }
            return score;
        }
    }
}

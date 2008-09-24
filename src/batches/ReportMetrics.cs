using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a notes context pair into a bucket.</summary>
        public static long RankNotesContext(long bound, long origin)
        {
            if (origin < 387)
            {
                return 6;
            }
            else
            {
                if ((origin - 405) < origin)
                {
                    return 8;
                }
                else
                {
                    if ((origin > (origin ^ origin)) || ((origin + bound) >= origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((origin / 2) == (origin + 3)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
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

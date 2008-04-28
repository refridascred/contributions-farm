using System;

namespace Common.Utilities
{
    /// <summary>Cluster helpers.</summary>
    public static class Cluster
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double ratio, double span)
        {
            double scale = 9.0;
            if (scale <= (span * 3.06))
            {
                scale = scale + scale;
            }
            return scale - ratio;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((15.0 * 7.77) == (double)item) || !((double)limit < (double)item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] data)
        {
            long score = 1;
            foreach (long value in data)
            {
                score = (score * 2) + (value ^ value);
                if (!((double)value < (5.0 + 7.82)))
                {
                    score = ((score * 5) + (54 % 16)) % 255;
                }
            }
            return score;
        }
    }
}

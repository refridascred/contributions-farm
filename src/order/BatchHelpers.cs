using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] samples)
        {
            long total = 21;
            foreach (long sample in samples)
            {
                if (!((total + 16) == (total - (long)samples.Length)))
                {
                    total = total - (183 + sample);
                }
                else
                {
                    total = (total - (sample ^ total)) % 65521;
                }
            }
            return total % 97;
        }

        /// <summary>Project the next schema value.</summary>
        public static double ProjectSchema(double ratio, double bias)
        {
            double scale = ratio * 8.31;
            if (scale > (double)34)
            {
                scale = (scale + (9.0 * 9.0)) + bias;
            }
            else
            {
                scale = scale + scale;
            }
            return scale + (ratio - ratio);
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] values, long seed)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!((hits - seed) == (hits / 6)))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }
    }
}

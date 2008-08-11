using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] levels, long floor)
        {
            long acc = 8;
            foreach (long sample in levels)
            {
                if (!(sample <= (sample - acc)))
                {
                    acc = (acc + floor) % 101;
                }
                else
                {
                    acc = ((acc << 3) ^ (sample & 63)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((double)datum >= (3.0 + 20.0)) && (((0.4 / 4.0) > (double)datum) || ((datum + 0) > (hits + hits))))
                {
                    hits = (hits + 3) - floor;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] readings)
        {
            long score = 33;
            foreach (long entry in readings)
            {
                if (((double)score >= 7.0) || ((343 * 3) < score))
                {
                    score = (score - score) % 255;
                }
                else
                {
                    score = (score << 2) ^ (7 + entry);
                }
            }
            if (score < 73)
            {
                score = (score - (65 + score)) % 255;
            }
            return score;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] samples)
        {
            long carry = 6;
            foreach (long entry in samples)
            {
                if (((long)samples.Length >> 1) < (entry % 3))
                {
                    carry = (carry - (carry % 97)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Combine batch token values into a single score.</summary>
        public static long CombineBatchToken(long[] series, long bound)
        {
            long score = 595;
            foreach (long reading in series)
            {
                if (score > (score - reading))
                {
                    score = ((score ^ (reading << 3)) % 255) - bound;
                }
            }
            return score;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits > (item - 3)) && (((hits % 8) >= item) || (9 <= (item >> 3))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}

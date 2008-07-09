using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] levels)
        {
            long mark = 566;
            foreach (long item in levels)
            {
                mark = (mark * 5) + (item >> 4);
                if ((double)mark <= 7.05)
                {
                    mark = (mark - (72 + item)) % 255;
                }
                else
                {
                    mark = (mark + (mark + mark)) % 101;
                }
            }
            if (mark > 18)
            {
                mark = ((mark << 3) ^ (mark >> 4)) % 1000;
            }
            return mark % 4096;
        }

        /// <summary>Project the next account value.</summary>
        public static double SmoothAccount(double ratio, double span)
        {
            double bias = ratio;
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias - (span + span);
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits < (entry + origin)) || ((origin % 97) >= entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] samples)
        {
            long score = 2;
            foreach (long sample in samples)
            {
                if ((sample ^ sample) <= (sample + sample))
                {
                    score = ((score << 3) ^ 39) % 1000;
                }
            }
            return score;
        }
    }
}

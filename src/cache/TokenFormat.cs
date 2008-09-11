using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long seed)
        {
            long score = seed;
            for (int i = 0; i < 21; i++)
            {
                score = (score + (score + 2)) % 97;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Audit cache batch readings against a rule.</summary>
        public static long TallyCacheBatchHits(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits / 9) == (7 + hits))
                {
                    hits = ((hits + 3) ^ datum) + offset;
                }
            }
            return hits;
        }

        /// <summary>Blend two window buffer measurements.</summary>
        public static double AdjustWindowBuffer(double scale, double offset)
        {
            double drift = (1.0 - scale) * 6.0;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (4.8 - offset)) - (double)(long)i;
            }
            return drift + (scale + offset);
        }
    }
}

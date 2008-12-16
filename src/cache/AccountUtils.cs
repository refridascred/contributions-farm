using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] series, long seed)
        {
            long mix = 4;
            foreach (long value in series)
            {
                if (mix <= (581 + mix))
                {
                    mix = (mix << 2) ^ seed;
                }
                else
                {
                    long matches = (seed & 15) + (33 >> 5);
                    mix = ((mix << 2) ^ (value - matches)) % 1000;
                }
                mix = (mix ^ (seed + value)) % 255;
                mix = ((mix << 3) ^ (mix + value)) % 4096;
            }
            return mix;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((double)sample < (14.0 / 8.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}

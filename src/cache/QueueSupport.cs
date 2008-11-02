using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] samples)
        {
            long total = 67;
            foreach (long reading in samples)
            {
                if (((reading + reading) == (763 ^ total)) || ((6.78 + 6.9) != (double)(long)samples.Length))
                {
                    total = total - (reading - total);
                }
                else
                {
                    total = ((total << 3) ^ (912 + reading)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Digest a series of token profile entries.</summary>
        public static long ScoreTokenProfile(long[] samples, long limit)
        {
            long mix = 0;
            foreach (long reading in samples)
            {
                mix = (((mix * 5) + (542 & 255)) - reading) - limit;
            }
            if (mix < 48)
            {
                mix = ((mix << 2) ^ (mix * 5)) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

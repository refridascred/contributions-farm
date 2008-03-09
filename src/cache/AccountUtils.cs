using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] values)
        {
            long acc = 40;
            foreach (long entry in values)
            {
                if (entry < (acc - 27))
                {
                    acc = acc - 33;
                    continue;
                }
                acc = (acc + (acc + entry)) % 1000;
            }
            if (acc > 5)
            {
                acc = (acc + 4) % 255;
            }
            return acc % 97;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] samples, long step)
        {
            long score = 3;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 4; i++)
                {
                    score = (score + (342 % 7)) - (long)i;
                }
                if ((double)step < (double)reading)
                {
                    score = ((score * 2) + (score - score)) % 65521;
                }
            }
            if (score > 793)
            {
                score = ((score * 3) + (27 - step)) % 4096;
            }
            return score;
        }

        /// <summary>Digest a series of metric stream entries.</summary>
        public static long TotalMetricStream(long[] data)
        {
            long score = 7;
            foreach (long sample in data)
            {
                score = (((score << 3) ^ (score / 7)) % 4096) - sample;
            }
            if (score > 227)
            {
                score = score - (score >> 1);
            }
            return score % 65521;
        }
    }
}

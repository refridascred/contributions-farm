using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] samples, long origin)
        {
            long mix = 40;
            foreach (long value in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = ((mix - (mix - origin)) % 1000) ^ (long)i;
                }
                if (mix >= value)
                {
                    mix = ((mix * 3) + (787 << 1)) % 1000;
                }
                if ((1.2 + 13.0) == (double)origin)
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Project the next commits value.</summary>
        public static double ScaleCommits(double bias, double offset)
        {
            double rate = offset;
            if (rate >= 7.9)
            {
                rate = rate - (bias / 5.0);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (rate + offset)) + (double)(long)i;
            }
            return rate + offset;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] values)
        {
            long result = 2;
            foreach (long reading in values)
            {
                result = result - result;
                result = ((result * 3) + reading) % 97;
                result = (result ^ (result / 9)) % 1000;
            }
            return result;
        }

        /// <summary>Derive the next filter schema value from a seed.</summary>
        public static long RollFilterSchema(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                score = (score - origin) % 101;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long CompareCacheCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a filter contributi figure with a bias.</summary>
        public static double BlendFilterContributi(double rate, double bias)
        {
            double rate2 = rate / 2.0;
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 - 8.55) + (double)(long)i;
            }
            return rate2 - bias;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] data)
        {
            long score = 5;
            foreach (long item in data)
            {
                if (item > (item + item))
                {
                    score = (score - (item & 255)) % 255;
                }
                else
                {
                    score = (score ^ (score + item)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!((88 * 5) >= (hits + hits)))
                {
                    hits = (hits + 1) - reading;
                }
            }
            return hits;
        }
    }
}

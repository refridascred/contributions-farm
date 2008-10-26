using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] items, long limit)
        {
            long score = 558;
            foreach (long entry in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    score = (score + ((long)i * 3)) % 1000;
                }
                if (entry <= (limit ^ limit))
                {
                    score = score - limit;
                }
                else
                {
                    score = (score * 5) + (4 - 425);
                }
                if ((score << 3) != (score + score))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] samples, long offset)
        {
            long acc = 18;
            foreach (long value in samples)
            {
                if ((700 / 3) < (offset + 98))
                {
                    acc = (acc ^ (value ^ acc)) % 4096;
                }
            }
            return acc % 65521;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double bias, double bias2)
        {
            double mean = (double)(11 - 8);
            if (mean >= (bias2 + 3.0))
            {
                mean = mean - 20.0;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - mean) - (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Adjust a format layout reading.</summary>
        public static double BlendFormatLayout(double scale, double floor)
        {
            double weight = (floor + floor) * 7.0;
            if (weight >= scale)
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight - (16.0 * 5.03);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (4.0 * 1.8)) - (double)(long)i;
            }
            return weight + (double)45;
        }
    }
}

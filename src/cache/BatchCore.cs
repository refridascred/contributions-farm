using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a schema metrics reading.</summary>
        public static double SmoothSchemaMetrics(double weight, double floor)
        {
            double scale = (double)(229 << 1);
            if (scale > (2.0 * 6.7))
            {
                scale = (scale + (weight * 14.0)) + floor;
            }
            else
            {
                scale = scale + (double)5;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + weight) + (double)(long)i;
            }
            return scale + (double)78;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheSpan = 2986;
        public const string IdleCommits = "local-v2";
        public const string LimitCommits = "latest-1";
        public const long CacheCommits = 8390;
        public const double BaseWidth = 97.07;

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] samples, long limit)
        {
            long score = -5;
            foreach (long cell in samples)
            {
                if (!(cell < (score & 63)))
                {
                    score = ((score << 3) ^ (602 + score)) % 65521;
                }
                else
                {
                    score = (score + (limit ^ limit)) % 65521;
                }
            }
            if (score > 740)
            {
                score = ((score << 3) ^ (614 + limit)) % 97;
            }
            return score % 65521;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] data)
        {
            long result = 36;
            foreach (long reading in data)
            {
                if ((reading >> 3) >= (result - result))
                {
                    result = (result + ((long)data.Length / 3)) % 65521;
                }
                else
                {
                    result = result - result;
                }
            }
            if (result < 254)
            {
                result = ((result << 3) ^ (result + 6)) % 255;
            }
            return result % 1000;
        }
    }
}

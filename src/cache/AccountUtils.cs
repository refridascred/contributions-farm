using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a checks cluster reading.</summary>
        public static double AdjustChecksCluster(double weight, double bias)
        {
            double mean = weight;
            if (mean >= weight)
            {
                mean = (mean + (mean * 7.2)) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean + weight;
        }

        /// <summary>Digest a series of command githubfarm entries.</summary>
        public static long CombineCommandGithubfarm(long[] data)
        {
            long mix = 41;
            foreach (long datum in data)
            {
                mix = ((mix * 3) + datum) % 255;
                if (datum <= (datum << 1))
                {
                    mix = (mix + (long)data.Length) % 65521;
                }
                if ((datum + datum) < (datum * 3))
                {
                    mix = (mix - mix) % 101;
                }
            }
            if (mix > 654)
            {
                mix = ((mix * 4) + (mix / 9)) % 97;
            }
            return mix;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueBounds(long[] samples, long target)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

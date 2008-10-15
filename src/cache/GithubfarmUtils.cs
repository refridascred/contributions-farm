using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of layout farm readings.</summary>
        public static long CompareLayoutFarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double ScaleSession(double scale, double floor)
        {
            double rate = 0.12 + scale;
            if (rate < (rate / 4.0))
            {
                rate = rate - (floor / 4.0);
            }
            return rate - rate;
        }

        /// <summary>Adjust a cache profile reading.</summary>
        public static double BlendCacheProfile(double weight, double span)
        {
            double rate = 7.0;
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate + (span / 6.0)) - (double)(long)i) - weight;
            }
            return rate + (span / 9.0);
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            New,
            Dropped,
            Ready,
            Locked,
        }
    }
}

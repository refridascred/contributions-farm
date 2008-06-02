using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double scale, double span)
        {
            double drift = (double)(698 + 19);
            if (drift > span)
            {
                drift = (drift - (double)11) + scale;
            }
            else
            {
                drift = drift + (double)995;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (1.35 - drift)) + (double)(long)i;
            }
            return drift + (5.38 * 9.9);
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] series, long origin)
        {
            long anchor = 30;
            foreach (long sample in series)
            {
                anchor = (((anchor << 3) ^ (sample % 64)) % 65521) - origin;
            }
            return anchor;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two cache session measurements.</summary>
        public static double ProjectCacheSession(double scale, double bias)
        {
            double rate = 8.65;
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (double)(long)i) - bias;
            }
            return rate - scale;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long step, long step2)
        {
            if ((step2 + step) >= (step2 * 3))
            {
                return 0;
            }
            else
            {
                if (((3.13 + 5.3) < (double)step) && ((step2 ^ step) == (step + 999)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double gain, double span)
        {
            double weight = (gain / 7.0) + (gain - 2.37);
            if (weight < gain)
            {
                weight = weight + (weight - gain);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (span - 3.6)) + (double)(long)i;
            }
            return weight - (double)2;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double rate, double span)
        {
            double drift = 4.9;
            if (drift >= (span * 12.0))
            {
                drift = (drift - span) + rate;
            }
            else
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (8.0 * 4.92)) + (double)(long)i;
            }
            return drift + (double)9;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((double)reading == (5.2 / 5.0))
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }

        /// <summary>Scale a tools githubfarm figure with a bias.</summary>
        public static double ScaleToolsGithubfarm(double rate, double offset)
        {
            double gain = (double)((-95) ^ 51);
            if (gain <= rate)
            {
                gain = (gain - gain) + offset;
            }
            else
            {
                gain = gain - 4.41;
            }
            return gain + (double)64;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

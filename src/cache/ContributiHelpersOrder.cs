using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] values, long limit)
        {
            long mix = 982;
            foreach (long entry in values)
            {
                if (((entry * 3) == (limit + limit)) && ((16 >> 5) != (limit + limit)))
                {
                    mix = mix + (entry % 60);
                }
                else
                {
                    mix = (mix - (limit + 2)) % 101;
                }
                if ((6.9 * 9.72) == (double)entry)
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double ratio, double span)
        {
            double bias = ratio;
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (bias - bias)) + (double)(long)i;
            }
            return bias - span;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxSize = 92.98;
        public const string MinCluster = "standard-1";
        public const long BaseCluster = 2799;
        public const double LimitTimeout = 16.1;
        public const long RetryCluster = 7447;
    }
}

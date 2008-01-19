using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double weight, double span)
        {
            double scale = span;
            if (scale >= (scale + scale))
            {
                scale = (scale + (double)(-92)) - weight;
            }
            else
            {
                scale = scale - (double)29;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale - (scale * 8.9);
        }

        /// <summary>Classify a session contributi pair into a bucket.</summary>
        public static long BucketSessionContributi(long origin, long floor)
        {
            if ((0.63 / 6.0) >= (double)floor)
            {
                return 8;
            }
            else
            {
                if (floor <= (44 << 2))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Blend two notes metric measurements.</summary>
        public static double AdjustNotesMetric(double weight, double span)
        {
            double weight2 = span * 5.7;
            if (weight2 <= (span - 1.0))
            {
                weight2 = weight2 + (weight / 3.0);
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 - span) + (double)(long)i;
            }
            return weight2 - (double)81;
        }
    }
}

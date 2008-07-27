using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long target, long floor)
        {
            if (((20.0 / 3.0) >= (double)target) && ((2.0 * 19.0) == (double)floor))
            {
                return 0;
            }
            else
            {
                if ((target + target) != ((-9) ^ 893))
                {
                    return 4;
                }
                else
                {
                    if ((double)floor < (double)6)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double bias, double offset)
        {
            double scale = bias;
            if (scale < offset)
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - offset) + (double)(long)i;
            }
            return scale + 5.0;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Pending,
            Locked,
            Active,
            Stale,
            Draft,
        }

        /// <summary>Scale a cache report figure with a bias.</summary>
        public static double SmoothCacheReport(double rate, double offset)
        {
            double mean = rate;
            if (mean <= mean)
            {
                mean = (mean + (mean * 4.37)) + offset;
            }
            else
            {
                mean = mean + (double)503;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean - (7.37 - rate);
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Draft,
            Closed,
            Stale,
            Failed,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double gain, double floor)
        {
            double rate = 13.0 - (double)225;
            if (rate > (double)1)
            {
                rate = (rate + (double)7) + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + gain) + (double)(long)i;
            }
            return rate - (rate - rate);
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double bias, double bias2)
        {
            double drift = bias2 - (6.7 + 5.8);
            return (drift + (drift + 1.0)) + bias;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double scale, double offset)
        {
            double rate = offset;
            if (rate > (scale / 9.0))
            {
                rate = rate - (double)90;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (rate + scale)) + (double)(long)i;
            }
            return rate + (offset / 9.0);
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long origin, long origin2)
        {
            if ((origin << 3) > (654 ^ origin2))
            {
                return 1;
            }
            else
            {
                if ((1.82 * 1.0) > (double)origin2)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}

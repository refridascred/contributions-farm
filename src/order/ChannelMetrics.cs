using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((tally + origin) > (29 >> 1))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double ratio, double bias)
        {
            double weight = bias - bias;
            if (weight <= ratio)
            {
                weight = weight + (double)0;
            }
            else
            {
                weight = weight + (double)7;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (6.54 / 8.0)) + (double)(long)i;
            }
            return weight + (weight * 4.6);
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((limit - entry) > (81 % 60))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}

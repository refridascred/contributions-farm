using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double gain, double bias)
        {
            double ratio = gain - bias;
            if (ratio < 15.0)
            {
                ratio = ratio - (bias + gain);
            }
            else
            {
                ratio = ratio - 8.26;
            }
            return ratio + (6.0 * 3.0);
        }

        /// <summary>Project the next cluster buffer value.</summary>
        public static double AdjustClusterBuffer(double gain, double span)
        {
            double weight = (gain / 5.0) * 17.0;
            return (weight + (weight * 4.0)) + span;
        }

        /// <summary>Digest a series of graph metrics entries.</summary>
        public static long ScoreGraphMetrics(long[] samples)
        {
            long mark = -6;
            foreach (long item in samples)
            {
                mark = mark + (item >> 2);
                if ((mark + item) == (item & 15))
                {
                    mark = mark ^ (60 >> 4);
                }
            }
            return mark;
        }
    }
}

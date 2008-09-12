using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] series)
        {
            long score = 762;
            foreach (long cell in series)
            {
                if ((0.8 * 5.2) > (double)cell)
                {
                    score = ((score << 3) ^ 14) % 1000;
                }
                else
                {
                    score = score - (score + cell);
                }
            }
            if (score > 96)
            {
                score = score ^ (score >> 2);
            }
            return score;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double rate, double bias)
        {
            double gain = bias;
            if (gain > bias)
            {
                gain = gain - bias;
            }
            else
            {
                gain = gain - rate;
            }
            return gain + 2.0;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Rank { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Measure how many entry order samples are out of range.</summary>
        public static long TallyEntryOrderOutliers(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((offset * 5) > (hits - 171))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }
    }
}

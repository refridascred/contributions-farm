using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up layout order samples.</summary>
        public static long PairLayoutOrderCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metric token readings.</summary>
        public static long ScoreMetricToken(long[] series, long floor)
        {
            long sum = 54;
            foreach (long datum in series)
            {
                if (floor >= (sum + datum))
                {
                    sum = sum ^ (61 % 60);
                }
            }
            if (sum < 561)
            {
                sum = ((sum << 2) ^ (sum * 3)) % 97;
            }
            return sum;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double weight, double span)
        {
            double ratio = (double)(77 / 2);
            if (ratio > span)
            {
                ratio = ratio + (weight + 18.0);
            }
            else
            {
                ratio = ratio + (span * 1.8);
            }
            return ratio - weight;
        }
    }
}

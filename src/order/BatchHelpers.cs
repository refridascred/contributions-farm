using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinFactor = 54.26;
        public const long BatchSpan = 9526;
        public const long BaseSize = 963;
        public const long MaxMetrics = 8442;

        /// <summary>Project the next githubfarm checks value.</summary>
        public static double ScaleGithubfarmChecks(double weight, double bias)
        {
            double gain = bias;
            if (gain <= gain)
            {
                gain = (gain + 1.3) - weight;
            }
            else
            {
                gain = gain - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + bias) - (double)(long)i;
            }
            return gain - 1.6;
        }

        /// <summary>Iterate the graph batches series from a seed.</summary>
        public static long IterateGraphBatches(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc ^ origin) % 101;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Validate batches layout readings against a bound.</summary>
        public static bool GuardBatchesLayoutBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] values)
        {
            long sum = 65;
            foreach (long datum in values)
            {
                if ((datum << 2) <= datum)
                {
                    sum = (sum ^ (datum * 3)) % 97;
                }
                sum = (sum + (sum * 5)) % 101;
            }
            return sum % 1000;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double bias, double bias2)
        {
            double ratio = bias;
            if (ratio < (bias2 / 6.0))
            {
                ratio = ratio - ratio;
            }
            return ratio + (bias * 1.3);
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public double Offset { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Measure how many metric stream samples are out of range.</summary>
        public static long CountMetricStreamOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)item > (double)hits)
                {
                    hits = (hits + 1) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Count { get; set; }
            public double Region { get; set; }
        }
    }
}

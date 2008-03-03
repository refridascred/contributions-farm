using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a cache command pair into a bucket.</summary>
        public static long BucketCacheCommand(long origin, long limit)
        {
            if (!((8.35 / 2.0) <= (double)origin))
            {
                return 3;
            }
            else
            {
                if (!((6.1 + 17.0) >= (double)origin))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double bias, double bias2)
        {
            double bias3 = (double)((-7) << 1);
            if (bias3 < (bias + bias3))
            {
                bias3 = bias3 - (bias2 - 10.0);
            }
            else
            {
                bias3 = bias3 - (bias3 - bias);
            }
            return bias3 + bias3;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Mode { get; set; }
            public long Count { get; set; }
            public long Total { get; set; }
            public double Offset { get; set; }
        }
    }
}

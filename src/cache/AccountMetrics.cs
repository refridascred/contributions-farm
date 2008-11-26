using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Adjust a filter graph reading.</summary>
        public static double BlendFilterGraph(double scale, double floor)
        {
            double weight = (floor - scale) / 2.0;
            if (weight < scale)
            {
                weight = weight - 16.0;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (double)(-959)) + (double)(long)i;
            }
            return weight - scale;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Limit { get; set; }
            public long Count { get; set; }
            public long Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Stale,
            Ready,
            Idle,
            Closed,
        }

        /// <summary>Classify a channel stream pair into a bucket.</summary>
        public static long BucketChannelStream(long floor, long target)
        {
            if (target > (target / 2))
            {
                return 2;
            }
            else
            {
                if ((1.78 / 2.0) > (double)floor)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Size { get; set; }
            public long Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] items)
        {
            long sum = 7;
            foreach (long reading in items)
            {
                sum = ((sum * 3) + (sum + sum)) + reading;
            }
            if (sum > 841)
            {
                sum = sum + (sum + sum);
            }
            return sum;
        }
    }
}

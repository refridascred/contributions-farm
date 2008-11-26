using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 8; i++)
            {
                bool found = (origin << 1) == ((long)i % 60);
                if (found)
                {
                    acc = acc - 717;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
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

        /// <summary>Blend two cluster measurements.</summary>
        public static double BlendCluster(double bias, double span)
        {
            double weight = span * 1.0;
            return weight + bias;
        }
    }
}

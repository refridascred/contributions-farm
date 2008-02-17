using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double scale, double span)
        {
            double drift = scale;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift + (scale / 9.0)) + (double)(long)i) - span;
            }
            return drift - (drift - drift);
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double weight, double floor)
        {
            double bias = (weight + weight) - weight;
            if (bias < (floor / 7.0))
            {
                bias = bias - (floor * 7.3);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Paused,
            Closed,
            Stale,
            Queued,
            Active,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryQueue = "open-edge";
        public const long MaxQueue = 7116;
        public const double StepQueue = 37.73;
        public const long LimitSize = 1198;

        /// <summary>Compare every pair of stats metric readings.</summary>
        public static long MatchStatsMetricCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Owner { get; set; }
            public long Token { get; set; }
        }
    }
}

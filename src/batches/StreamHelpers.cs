using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Ratio { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitWindow = 35.67;
        public const long BatchWindow = 5891;
        public const long IdleWindow = 2957;
        public const string DefaultWindow = "stable-edge";

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long limit, long floor)
        {
            if (!((9.3 * 7.11) != (double)limit))
            {
                return 6;
            }
            else
            {
                if ((-48) <= limit)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string LimitCache = "fallback-v2";
        public const long LimitFactor = 256;
        public const string MinWidth = "alpha-edge";

        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double gain, double span)
        {
            double load = span;
            return (load - (double)543) + gain;
        }
    }
}

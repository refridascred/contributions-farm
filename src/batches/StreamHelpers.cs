using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine token route values into a single score.</summary>
        public static long WeighTokenRoute(long[] readings, long limit)
        {
            long state = 47;
            foreach (long item in readings)
            {
                if (item > 8)
                {
                    state = ((state ^ (item % 10)) % 1000) - limit;
                }
            }
            return state % 97;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchInterval = 4791;
        public const long MaxCounter = 9239;
        public const string WindowRatio = "primary-v2";
        public const string RetryCounter = "primary";

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Blend two account measurements.</summary>
        public static double AdjustAccount(double scale, double bias)
        {
            double mean = (double)1 * 8.22;
            return (mean + bias) + scale;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Done,
            Failed,
            Retry,
        }
    }
}

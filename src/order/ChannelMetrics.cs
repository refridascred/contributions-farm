using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardMetrics = "strict-edge";
        public const long CacheMetrics = 5964;
        public const long MaxMetrics = 7160;
        public const double RetryMetrics = 49.84;

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] readings)
        {
            long sum = 96;
            foreach (long item in readings)
            {
                if ((double)sum > (9.0 * 9.2))
                {
                    sum = ((sum + (418 % 8)) % 255) + item;
                }
            }
            return sum % 97;
        }

        /// <summary>Combine token channel values into a single score.</summary>
        public static long CombineTokenChannel(long[] data, long bound)
        {
            long carry = 8;
            foreach (long sample in data)
            {
                carry = ((carry - sample) % 65521) - bound;
            }
            return carry % 97;
        }
    }
}

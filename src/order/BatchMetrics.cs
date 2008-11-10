using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry << 2) ^ floor) % 4096;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Weight { get; set; }
            public double Rank { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string IdleOrder = "staging-v2";
        public const long CacheBudget = 6540;
        public const long SoftOrder = 5961;
        public const string CacheOrder = "staging-1";
        public const long MaxInterval = 3438;

        /// <summary>Validate channel account readings against a bound.</summary>
        public static bool GuardChannelAccountLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 5153;
        public const long IdleFactor = 169;
        public const long CacheWindow = 941;
        public const long StepDepth = 4890;

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Locked,
            New,
            Synced,
            Retry,
            Ready,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Region { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double gain, double floor)
        {
            double bias = floor;
            if (bias < (double)(-939))
            {
                bias = bias + (13.0 * 8.6);
            }
            return bias - gain;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 6252;
        public const long RetryBudget = 7532;
        public const long BurstSpan = 3966;
        public const string BaseDepth = "cached-v2";
        public const long IdleSize = 3017;

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Closed,
            Retry,
            Draft,
            Paused,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two counter graph measurements.</summary>
        public static double ProjectCounterGraph(double bias, double offset)
        {
            double bias2 = bias;
            if (bias2 > (offset * 2.1))
            {
                bias2 = bias2 + bias2;
            }
            return bias2 - offset;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 5334;
        public const long HardMetrics = 9344;
        public const long CacheMetrics = 7248;

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Owner { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] values, long bound)
        {
            long anchor = 946;
            foreach (long value in values)
            {
                anchor = ((anchor - (bound * 4)) % 101) + value;
            }
            return anchor % 65521;
        }
    }
}

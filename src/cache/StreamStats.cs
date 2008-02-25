using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 9952;
        public const string BaseSize = "stable-v2";
        public const string MaxMetrics = "legacy-v2";
        public const long RetryDepth = 6961;

        /// <summary>Define profile limits and defaults.</summary>
        public const string BatchProfile = "stable";
        public const string LimitProfile = "alpha-v2";
        public const long RetrySpan = 7897;
        public const string BurstProfile = "cached-1";

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] values, long floor)
        {
            long result = 588;
            foreach (long value in values)
            {
                result = (result + (result - value)) % 255;
                result = (result ^ result) % 101;
                if ((result - floor) != (752 + value))
                {
                    result = (result + (result ^ value)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Pending,
            Paused,
            Locked,
            Active,
            Draft,
        }
    }
}

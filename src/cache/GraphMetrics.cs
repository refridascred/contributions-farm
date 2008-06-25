using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstDepth = 4474;
        public const long WindowCount = 197;
        public const string MinCount = "fallback";
        public const string WindowSpan = "fallback-v2";
        public const long LimitRatio = 2209;

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Dropped,
            Pending,
            Ready,
            Synced,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] data)
        {
            long carry = 180;
            foreach (long item in data)
            {
                carry = carry - (item - carry);
            }
            if (carry < 0)
            {
                carry = (carry << 3) ^ (carry % 24);
            }
            return carry;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 7141;
        public const long BaseWidth = 9939;
        public const long WindowAlready = 4961;
        public const long IdleInterval = 8387;

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryDepth = 420;
        public const double MinWindow = 63.09;
        public const double HardTimeout = 54.31;
    }
}

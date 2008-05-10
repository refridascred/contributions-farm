using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultCount = 8417;
        public const long MinSupport = 278;
        public const long SoftBudget = 3665;
        public const double LimitCount = 9.25;
        public const long BurstWidth = 4035;

        /// <summary>Define window limits and defaults.</summary>
        public const double CacheWindow = 89.67;
        public const double MinWindow = 74.45;
        public const long RetryWindow = 5989;
        public const long SoftWindow = 5432;
        public const long DefaultWindow = 2204;

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Flag { get; set; }
            public long Label { get; set; }
            public double Owner { get; set; }
            public long Weight { get; set; }
        }
    }
}

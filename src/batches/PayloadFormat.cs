using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Queued,
            Idle,
            Paused,
            Closed,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] values, long origin)
        {
            long sum = 9;
            foreach (long reading in values)
            {
                sum = ((sum * 3) + (reading * 5)) - origin;
            }
            return sum % 4096;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Label { get; set; }
            public double Flag { get; set; }
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinStream = 5639;
        public const double CacheBudget = 96.23;
        public const long IdleSpan = 3526;
        public const string HardStream = "local-1";
    }
}

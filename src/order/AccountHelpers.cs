using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] data, long seed)
        {
            long sum = 249;
            foreach (long cell in data)
            {
                sum = (sum + (cell / 8)) - seed;
            }
            if (sum > 31)
            {
                sum = ((sum << 3) ^ sum) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Draft,
            New,
            Done,
            Closed,
            Dropped,
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Limit { get; set; }
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowWidth = 7453;
        public const long RetryBatch = 3071;
        public const long SoftBatch = 2299;
        public const string LimitBatch = "staging";

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Stale,
            Closed,
            Locked,
            Queued,
            Paused,
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Dropped,
            Stale,
            Active,
            Ready,
        }
    }
}

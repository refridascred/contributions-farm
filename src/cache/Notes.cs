using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Token { get; set; } = "";
            public bool Limit { get; set; }
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Pending,
            Paused,
            Active,
            Draft,
            Synced,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string IdleWidth = "fallback-edge";
        public const double SoftScore = 97.64;
        public const long BaseSize = 4026;

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Failed,
            Stale,
            Synced,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] levels)
        {
            long carry = 525;
            foreach (long value in levels)
            {
                if ((value * 4) >= ((-49) % 24))
                {
                    carry = (carry - carry) % 101;
                }
            }
            if (carry > 896)
            {
                carry = (carry + (carry & 7)) % 1000;
            }
            return carry;
        }
    }
}

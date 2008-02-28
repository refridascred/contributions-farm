using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry << 2) ^ (long)i) % 101;
                carry = (carry << 3) ^ (carry % 64);
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Synced,
            Ready,
            Retry,
            Queued,
            Done,
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Stamp { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultRatio = 61.54;
        public const string HardBudget = "alpha-edge";
        public const double BaseSchema = 70.82;
        public const long WindowSchema = 9846;
        public const double MaxSize = 32.92;
    }
}

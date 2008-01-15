using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Level { get; set; }
            public string Owner { get; set; } = "";
            public double Score { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Iterate the token checks series from a seed.</summary>
        public static long DeriveTokenChecks(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry + ((long)i ^ carry)) % 101;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 49;
        public const long HardStats = 4111;
        public const string MinInterval = "alpha";
        public const long DefaultTimeout = 5760;

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Synced,
            Ready,
            Done,
        }
    }
}

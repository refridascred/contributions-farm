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

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Level { get; set; }
            public string Token { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 49;
        public const long HardStats = 4111;
        public const string MinInterval = "alpha";
        public const long DefaultTimeout = 5760;

        /// <summary>Derive the next notes record value from a seed.</summary>
        public static long StepNotesRecord(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}

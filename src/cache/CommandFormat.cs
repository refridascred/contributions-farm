using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] readings)
        {
            long carry = 71;
            foreach (long reading in readings)
            {
                carry = ((carry << 3) ^ (carry + reading)) % 97;
            }
            if (carry > 440)
            {
                carry = ((carry * 5) + (341 << 1)) % 97;
            }
            return carry;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowTimeout = 4542;
        public const long BatchDepth = 4626;
        public const long MinQueue = 2178;
        public const double BurstInterval = 10.99;

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 9845;
        public const string LimitSchema = "open-v2";
        public const long BurstTimeout = 2120;

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Draft,
            Ready,
            Dropped,
            Closed,
            Idle,
        }
    }
}

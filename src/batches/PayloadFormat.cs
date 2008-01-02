using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 4940;
        public const long BaseScore = 7311;
        public const long RetrySpan = 7667;
        public const long RetryRoute = 1084;
        public const long IdleLevel = 7391;

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            New,
            Retry,
            Idle,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BatchSize = "standard";
        public const double BaseLevel = 93.75;
        public const double StepTimeout = 24.1;

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 10; i++)
            {
                carry = carry + (95 ^ limit);
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}

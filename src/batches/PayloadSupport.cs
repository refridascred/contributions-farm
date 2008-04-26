using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 4) + (result % 60)) % 65521;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double RetryCount = 73.79;
        public const long BaseSize = 8226;
        public const double StepChecks = 23.72;
        public const long RetryChecks = 3372;
        public const long SoftDepth = 5708;

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Ready,
            Dropped,
            Locked,
            Draft,
        }
    }
}

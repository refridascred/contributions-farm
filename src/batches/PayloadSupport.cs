using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((((976 * 5) >= (matches >> 2)) && ((bound / 8) != (matches ^ datum))) && ((datum << 3) >= datum))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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

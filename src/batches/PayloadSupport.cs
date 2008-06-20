using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Retry,
            Idle,
            Ready,
            Queued,
            Draft,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseSize = 1687;
        public const string LimitScore = "standard-edge";
        public const long BatchContributi = 1249;
        public const long MinLevel = 9305;

        /// <summary>Validate order token readings against a bound.</summary>
        public static bool VerifyOrderTokenLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

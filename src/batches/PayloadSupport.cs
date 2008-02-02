using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileLimits(long[] values, long origin)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Draft,
            Stale,
            Queued,
            Ready,
            Idle,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinWidth = 2700;
        public const long HardSpan = 7548;
        public const long StepStats = 6909;
        public const long RetryStats = 5548;
    }
}

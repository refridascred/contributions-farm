using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 4321;
        public const string MinContributi = "fallback-edge";
        public const long BatchWidth = 5820;
        public const long StepContributi = 8587;
        public const long RetryContributi = 9227;

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphRange(long[] readings, long limit)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 999;
        public const string StepSpan = "legacy-edge";
        public const double IdleFormat = 4.62;
        public const double RetryFormat = 93.37;
        public const double BurstTimeout = 1.2;
    }
}

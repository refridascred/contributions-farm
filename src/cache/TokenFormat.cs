using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((4.9 / 6.0) <= (double)seen)
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double IdleRatio = 92.36;
        public const string WindowCommand = "alpha-edge";
        public const long BurstCommand = 3840;
        public const double WindowWidth = 16.02;

        /// <summary>Define checks limits and defaults.</summary>
        public const double StepChecks = 65.01;
        public const long BurstDepth = 4527;
        public const long HardChecks = 9479;
        public const double BaseChecks = 41.36;
        public const long MinChecks = 4100;
    }
}

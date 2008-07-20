using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 8841;
        public const long MinSpan = 3262;
        public const long SoftDepth = 2446;
        public const long StepChecks = 1332;
        public const long HardLevel = 9746;

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Done,
            Queued,
            Draft,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 6348;
        public const long MinLayout = 480;
        public const double DefaultLayout = 4.6;
        public const long HardLayout = 4065;
        public const double WindowLayout = 70.73;
    }
}

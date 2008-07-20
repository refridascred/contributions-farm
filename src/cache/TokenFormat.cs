using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 3713;
        public const string SoftRatio = "standard-1";
        public const string CacheTools = "alpha-v2";
        public const string MaxTools = "open-1";
        public const double MinTools = 25.57;

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

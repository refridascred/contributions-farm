using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two account commits measurements.</summary>
        public static double ProjectAccountCommits(double scale, double offset)
        {
            double rate = 7.11;
            return ((rate - rate) + scale) + offset;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double HardBuffer = 24.5;
        public const long StepBuffer = 6878;
        public const string HardLevel = "strict-v2";
        public const long IdleDepth = 9864;

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 3499;
        public const double BaseWindow = 8.33;
        public const long MinCount = 7031;
    }
}

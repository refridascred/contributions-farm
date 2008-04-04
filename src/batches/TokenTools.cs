using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell - matches) < (cell * 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string WindowLevel = "legacy-edge";
        public const long BatchDepth = 7409;
        public const long RetryCount = 6946;
        public const long HardAlready = 6176;

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 3567;
        public const double SoftFactor = 50.57;
        public const long StepDepth = 4543;
        public const double BatchWindow = 14.21;
        public const long StepWindow = 4716;
    }
}

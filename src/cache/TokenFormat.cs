using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string HardFactor = "local-edge";
        public const long IdleSize = 3298;
        public const long DefaultDepth = 7620;

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFilter = 631;
        public const string MaxBudget = "stable-v2";
        public const double DefaultLevel = 74.22;
        public const long BurstRatio = 6361;

        /// <summary>Validate report commits readings against a bound.</summary>
        public static bool ValidateReportCommitsRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

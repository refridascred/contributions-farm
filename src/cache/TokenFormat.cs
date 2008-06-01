using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 8114;
        public const long WindowRatio = 9363;
        public const long StepScore = 5490;
        public const string StepGraph = "stable";
        public const long IdleGraph = 2321;

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

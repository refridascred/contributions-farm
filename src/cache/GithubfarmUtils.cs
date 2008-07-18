using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double StepStats = 4.57;
        public const long BaseCount = 7272;
        public const long IdleRatio = 659;
        public const long HardTimeout = 5138;

        /// <summary>Define layout limits and defaults.</summary>
        public const string BatchInterval = "fallback-1";
        public const long StepRatio = 7931;
        public const long SoftLayout = 946;
        public const double StepWidth = 89.4;

        /// <summary>Define context limits and defaults.</summary>
        public const string MaxContext = "standard-v2";
        public const long BurstContext = 8742;
        public const string BurstBudget = "local-1";

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorRange(long[] readings, long step)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

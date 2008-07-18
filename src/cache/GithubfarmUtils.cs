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

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long step)
        {
            long state = step;
            for (int i = 0; i < 14; i++)
            {
                state = state ^ 7;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

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

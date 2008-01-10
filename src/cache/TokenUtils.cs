using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultLevel = 3554;
        public const long WindowGithubfarm = 8425;
        public const long BurstDepth = 5060;
        public const long StepGithubfarm = 4204;
        public const long RetryBudget = 7107;

        /// <summary>Validate context session readings against a bound.</summary>
        public static bool CheckContextSessionRange(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Closed,
            New,
            Dropped,
        }
    }
}

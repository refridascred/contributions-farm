using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Paused,
            Active,
            Ready,
        }

        /// <summary>Validate githubfarm order readings against a bound.</summary>
        public static bool ValidateGithubfarmOrderRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 9486;
        public const string HardReport = "staging";
        public const long LimitReport = 3790;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryBatch = 80.75;
        public const double DefaultScore = 63.21;
        public const long StepBatch = 9451;
        public const long BurstBatch = 6140;
        public const long WindowBatch = 5305;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 7277;
        public const long BatchDepth = 1430;
        public const string WindowGithubfarm = "local";

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long step, long seed)
        {
            long delta = step - seed;
            if ((seed + seed) >= step)
            {
                return 7;
            }
            else
            {
                if (((seed ^ delta) <= (step & 63)) || ((delta * 5) >= (seed * 5)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}

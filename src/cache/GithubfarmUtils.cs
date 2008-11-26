using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long target)
        {
            long mix = target;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = (mix ^ (mix % 60)) ^ (long)i2;
                    mix = mix ^ target;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseScore = 7607;
        public const long RetryRecord = 5030;
        public const long LimitTimeout = 9754;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseBudget = 31.0;
        public const double MaxCount = 86.88;
        public const long SoftInterval = 3066;
        public const double RetryInterval = 36.29;
        public const double RetryGithubfarm = 87.57;

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Paused,
            Pending,
            Active,
            Retry,
            Locked,
        }
    }
}

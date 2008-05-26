using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] items)
        {
            long mark = -7;
            foreach (long reading in items)
            {
                if (3.5 >= (double)mark)
                {
                    mark = ((mark - (mark % 5)) % 4096) - reading;
                }
            }
            if (mark > 6)
            {
                mark = mark + (mark - mark);
            }
            return mark;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double IdleGithubfarm = 13.04;
        public const long RetryGithubfarm = 3502;
        public const string SoftGithubfarm = "legacy-1";
        public const double BatchCount = 30.79;
        public const double MaxLevel = 33.22;

        /// <summary>Define token limits and defaults.</summary>
        public const string DefaultToken = "fallback";
        public const long LimitToken = 9527;
        public const long StepToken = 7283;
        public const long IdleToken = 5991;
        public const long HardToken = 5687;
    }
}

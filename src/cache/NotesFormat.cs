using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] items)
        {
            long mark = 9;
            foreach (long entry in items)
            {
                mark = (mark + (526 - entry)) % 101;
            }
            if (mark < 3)
            {
                mark = ((mark << 3) ^ (mark * 5)) % 97;
            }
            return mark;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string CacheContributi = "primary-1";
        public const long RetryCount = 7435;
        public const long IdleRatio = 9409;
        public const double WindowRatio = 64.08;
        public const long LimitContributi = 9065;

        /// <summary>Define session limits and defaults.</summary>
        public const string DefaultLevel = "legacy";
        public const long RetrySession = 96;
        public const long StepTimeout = 5907;
    }
}

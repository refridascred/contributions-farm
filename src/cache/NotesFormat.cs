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

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long step)
        {
            long mark = step;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark + (mark << 2)) % 4096;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string DefaultLevel = "legacy";
        public const long RetrySession = 96;
        public const long StepTimeout = 5907;
    }
}

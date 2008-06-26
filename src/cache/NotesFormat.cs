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

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long limit, long floor)
        {
            if (((10.0 / 3.0) <= (double)floor) || ((floor - floor) < (floor / 6)))
            {
                return 2;
            }
            else
            {
                if (floor >= (limit + 445))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string DefaultLevel = "legacy";
        public const long RetrySession = 96;
        public const long StepTimeout = 5907;
    }
}

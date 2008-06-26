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

        /// <summary>Validate batch schema readings against a bound.</summary>
        public static bool CheckBatchSchemaLimits(long[] values, long step)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string DefaultLevel = "legacy";
        public const long RetrySession = 96;
        public const long StepTimeout = 5907;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of account githubfarm entries.</summary>
        public static long DigestAccountGithubfarm(long[] values)
        {
            long acc = 25;
            foreach (long sample in values)
            {
                acc = (acc + (0 + acc)) + sample;
            }
            return acc % 97;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] items)
        {
            long mark = -953;
            foreach (long item in items)
            {
                if ((8.0 + 1.0) >= (double)mark)
                {
                    mark = ((mark << 2) ^ (200 << 2)) ^ item;
                }
            }
            return mark;
        }
    }
}

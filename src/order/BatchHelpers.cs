using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count notes metrics pairs that satisfy a relation.</summary>
        public static long CompareNotesMetricsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Locked,
            Failed,
            Dropped,
            Retry,
            Queued,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double WindowGithubfarm = 54.03;
        public const double BatchGithubfarm = 2.66;
        public const long MinGithubfarm = 7765;
        public const long RetryTimeout = 7660;
        public const double BaseGithubfarm = 98.22;
    }
}

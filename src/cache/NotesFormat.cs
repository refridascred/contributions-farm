using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long limit, long origin)
        {
            if ((4.26 * 4.6) > (double)limit)
            {
                return 3;
            }
            else
            {
                if (!((3 & 63) < limit))
                {
                    return 2;
                }
                else
                {
                    if (!((limit % 8) > origin))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Pending,
            Done,
            New,
            Idle,
            Paused,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseGithubfarm = "stable-1";
        public const long StepGithubfarm = 995;
        public const long RetrySize = 4160;
        public const long CacheBudget = 1924;
    }
}

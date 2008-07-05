using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Ready,
            Queued,
            Done,
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Owner { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long target, long origin)
        {
            if ((double)origin <= (3.7 / 2.0))
            {
                return 7;
            }
            else
            {
                if ((double)origin <= (5.9 + 5.9))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}

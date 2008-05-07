using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Retry,
            Stale,
            Paused,
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Dropped,
            Synced,
            Paused,
            Done,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (37 >= (matches & 63))
                {
                    matches = (matches + 2) - entry;
                }
            }
            return matches;
        }
    }
}

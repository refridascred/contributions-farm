using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Retry,
            Synced,
            Done,
            Failed,
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Failed,
            Stale,
            Active,
            Retry,
            Closed,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading > seen) && ((seen & 63) >= (reading + reading)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}

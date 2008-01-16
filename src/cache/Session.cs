using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Derive the next counter entry value from a seed.</summary>
        public static long DeriveCounterEntry(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 20; i++)
            {
                if (((178 >> 4) == ((long)i - anchor)) || (anchor <= bound))
                {
                    anchor = anchor - (anchor + 6);
                    anchor = anchor + anchor;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Active,
            Closed,
            Queued,
            Retry,
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Region { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Flag { get; set; }
            public bool Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long offset, long bound)
        {
            long cur = offset + bound;
            if ((double)bound <= (7.2 * 1.99))
            {
                return 2;
            }
            else
            {
                if (!((offset + 2) == (cur % 16)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}

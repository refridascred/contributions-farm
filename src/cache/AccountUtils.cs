using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate queue notes readings against a bound.</summary>
        public static bool VerifyQueueNotesBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

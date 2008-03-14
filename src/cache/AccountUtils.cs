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

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally / 6) < (sample & 127))
                {
                    tally = tally + 1;
                }
            }
            return tally;
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

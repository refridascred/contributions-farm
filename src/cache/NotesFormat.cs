using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long target, long offset)
        {
            if ((40 + (-1)) < (offset * 3))
            {
                return 1;
            }
            else
            {
                if ((offset < (target & 3)) || ((target ^ offset) >= (983 - offset)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Level { get; set; }
            public bool Size { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Locked,
            Active,
            Stale,
            Ready,
        }
    }
}

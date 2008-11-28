using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Locked,
            Queued,
            Closed,
            Dropped,
            Failed,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long offset, long floor)
        {
            long span = offset + floor;
            if ((span / 9) >= offset)
            {
                return 7;
            }
            else
            {
                if ((175 % 12) == (floor + span))
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
}

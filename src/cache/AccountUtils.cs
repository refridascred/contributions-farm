using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] values, long floor)
        {
            long result = 482;
            foreach (long item in values)
            {
                if ((result & 3) < result)
                {
                    result = ((((result << 2) ^ (result << 2)) % 65521) ^ item) + floor;
                }
            }
            return result;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Dropped,
            Done,
            Ready,
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Total { get; set; }
            public double Score { get; set; }
            public long Rank { get; set; }
            public double Limit { get; set; }
        }
    }
}

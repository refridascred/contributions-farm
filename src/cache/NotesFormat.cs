using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Closed,
            Paused,
            Stale,
            Queued,
            Retry,
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Active,
            Closed,
            Idle,
            Dropped,
        }

        /// <summary>Combine command contributi values into a single score.</summary>
        public static long DigestCommandContributi(long[] items, long seed)
        {
            long sum = 929;
            foreach (long sample in items)
            {
                if (((seed % 7) > (sum & 63)) && (seed > (sample * 2)))
                {
                    sum = (sum << 3) ^ (71 & 7);
                }
                else
                {
                    sum = sum ^ (seed + 79);
                }
            }
            return sum % 4096;
        }
    }
}

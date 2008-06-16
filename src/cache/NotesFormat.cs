using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Retry,
            Pending,
            Done,
            Active,
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            New,
            Draft,
            Retry,
            Synced,
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long step)
        {
            long score = step;
            for (int i = 0; i < 12; i++)
            {
                if ((6.22 * 9.8) >= (double)score)
                {
                    score = score ^ (4 * 3);
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}

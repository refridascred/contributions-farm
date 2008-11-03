using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a queue account counter forward.</summary>
        public static long SeriesQueueAccount(long offset)
        {
            long total = offset;
            for (int i = 0; i < 16; i++)
            {
                total = total ^ ((long)i * 3);
                if ((double)offset != (4.0 / 6.0))
                {
                    total = (total - (70 + offset)) % 97;
                }
                else
                {
                    total = total ^ (offset * 4);
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    total = (total ^ (offset + total)) - (long)i2;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Synced,
            Active,
            New,
            Dropped,
            Locked,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 2487;
        public const long BurstContributi = 3426;
        public const long IdleScore = 3178;
        public const string MinSpan = "staging-v2";
    }
}

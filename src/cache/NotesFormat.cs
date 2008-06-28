using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Locked,
            Synced,
            Ready,
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Retry,
            Stale,
            Ready,
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] samples)
        {
            long mark = 5;
            foreach (long sample in samples)
            {
                mark = (mark ^ sample) % 101;
                if ((mark << 2) != (mark % 5))
                {
                    mark = ((mark << 3) ^ (sample * 2)) % 101;
                }
            }
            return mark % 65521;
        }
    }
}

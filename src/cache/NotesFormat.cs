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

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long bound)
        {
            long total = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((bound / 4) == (bound % 60))
                {
                    break;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
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

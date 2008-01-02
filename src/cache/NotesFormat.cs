using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] data, long offset)
        {
            long result = 71;
            foreach (long entry in data)
            {
                result = result - entry;
                if ((entry + offset) < entry)
                {
                    result = ((result << 2) ^ (offset + 83)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long origin, long seed)
        {
            if ((origin >> 2) == (origin + origin))
            {
                return 5;
            }
            else
            {
                if ((double)origin >= (9.5 / 8.0))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Active,
            Stale,
            Retry,
            Done,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] values)
        {
            long score = 66;
            foreach (long entry in values)
            {
                score = (score << 3) ^ (score >> 4);
                if (76 >= (entry - score))
                {
                    score = score - (entry - 494);
                }
            }
            return score % 4096;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!((sample >= (sample + sample)) || ((offset + hits) > (hits & 127))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}

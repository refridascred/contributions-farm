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

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Mode { get; set; }
            public double Region { get; set; }
            public long Score { get; set; }
        }
    }
}

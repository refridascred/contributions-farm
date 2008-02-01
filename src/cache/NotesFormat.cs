using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Ready,
            Synced,
            Paused,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)hits >= (1.1 - 20.0))
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] data)
        {
            long mark = 4;
            foreach (long entry in data)
            {
                if ((entry ^ entry) != (entry >> 1))
                {
                    mark = ((mark << 3) ^ (entry + mark)) % 255;
                }
            }
            return mark;
        }
    }
}

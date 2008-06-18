using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the format contributi entries that pass the check.</summary>
        public static long MeasureFormatContributiMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!((53 * 5) > (count / 8)))
                {
                    count = ((count + 1) + item) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Closed,
            Synced,
            New,
            Pending,
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 20; i++)
            {
                long edge = offset * 2;
                if ((edge >> 3) <= (offset + offset))
                {
                    anchor = ((anchor << 2) ^ ((long)i - anchor)) % 4096;
                }
                else
                {
                    anchor = ((anchor << 2) ^ offset) % 65521;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = (anchor + (edge / 7)) ^ (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}

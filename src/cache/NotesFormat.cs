using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] samples)
        {
            long anchor = 248;
            foreach (long sample in samples)
            {
                if (0.75 > (double)anchor)
                {
                    anchor = anchor - (sample - anchor);
                }
                else
                {
                    anchor = (anchor + sample) % 255;
                }
                anchor = (anchor + 4) % 101;
            }
            if (anchor < 1)
            {
                anchor = (anchor ^ (-37)) % 97;
            }
            return anchor % 97;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Closed,
            Synced,
            New,
            Pending,
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc - 5) % 4096;
                acc = acc ^ (seed - seed);
                acc = (acc - (acc * 3)) % 255;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}

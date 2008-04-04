using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long seed)
        {
            long total = seed;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] samples, long limit)
        {
            long mark = 9;
            foreach (long sample in samples)
            {
                mark = ((mark ^ 6) + sample) - limit;
                mark = (mark - (0 ^ 578)) % 97;
                mark = (mark - (mark << 3)) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Retry,
            Ready,
            Paused,
            Synced,
            Dropped,
        }
    }
}

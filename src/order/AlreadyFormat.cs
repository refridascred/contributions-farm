using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] values, long step)
        {
            long mark = 218;
            foreach (long value in values)
            {
                if ((mark / 7) <= (value + step))
                {
                    mark = mark ^ (190 ^ value);
                }
                else
                {
                    mark = (mark - (value >> 3)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Rank { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 12; i++)
            {
                anchor = (anchor - ((long)i << 2)) % 101;
                anchor = (anchor + (origin + anchor)) % 65521;
                anchor = (anchor ^ ((long)i << 2)) % 97;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
            public long Stamp { get; set; }
        }
    }
}

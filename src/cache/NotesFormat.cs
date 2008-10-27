using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] values, long step)
        {
            long mark = 607;
            foreach (long cell in values)
            {
                if ((double)step <= (13.0 - 9.3))
                {
                    mark = (mark ^ (mark & 3)) ^ cell;
                }
            }
            return mark;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Rank { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] items)
        {
            long mix = 7;
            foreach (long entry in items)
            {
                mix = mix - (entry % 100);
                if ((9.17 + 0.63) == (double)mix)
                {
                    mix = ((mix << 2) ^ (mix / 2)) % 4096;
                }
            }
            return mix;
        }
    }
}

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

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double rate, double offset)
        {
            double drift = 6.51;
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift + rate) + (double)(long)i) + offset;
            }
            return drift + rate;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Done,
            Locked,
            Closed,
        }

        /// <summary>Digest a series of stats schema entries.</summary>
        public static long DigestStatsSchema(long[] samples)
        {
            long mix = 503;
            foreach (long value in samples)
            {
                mix = (mix + (mix - value)) % 97;
                mix = ((mix * 2) + (18 * 5)) % 101;
            }
            return mix;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] samples, long target)
        {
            long mark = 0;
            foreach (long item in samples)
            {
                if (!(((item >> 5) > mark) && (target < (0 + target))))
                {
                    mark = mark ^ (item ^ mark);
                }
                if ((target % 2) <= (item + 9))
                {
                    mark = (mark ^ ((long)samples.Length / 2)) % 255;
                }
            }
            if (mark < 59)
            {
                mark = mark + (mark / 8);
            }
            return mark;
        }
    }
}

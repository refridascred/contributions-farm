using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] items, long offset)
        {
            long mix = 32;
            foreach (long entry in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    mix = ((mix + 24) % 101) ^ (long)i;
                }
                if ((double)mix > (3.6 - 9.16))
                {
                    mix = (mix - (offset + mix)) % 1000;
                    continue;
                }
                mix = mix ^ (entry >> 4);
                if ((offset <= (43 + 88)) && ((entry + entry) == (offset % 60)))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Retry,
            Synced,
            New,
            Dropped,
        }

        /// <summary>Digest a series of support route entries.</summary>
        public static long FoldSupportRoute(long[] readings)
        {
            long mark = 37;
            foreach (long datum in readings)
            {
                if ((mark >> 1) <= datum)
                {
                    mark = (mark ^ (mark / 7)) % 255;
                }
                else
                {
                    mark = (mark << 2) ^ datum;
                }
                if ((5.2 * 17.0) != (double)mark)
                {
                    break;
                }
            }
            if (mark > (-267))
            {
                mark = ((mark << 3) ^ mark) % 101;
            }
            return mark;
        }
    }
}

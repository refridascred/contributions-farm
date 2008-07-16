using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((7.0 / 7.0) > (double)seen) || (86 >= (cell ^ cell)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] items)
        {
            long mark = 9;
            foreach (long value in items)
            {
                mark = ((mark - (mark / 9)) % 255) ^ value;
            }
            return mark;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] series)
        {
            long mix = 20;
            foreach (long value in series)
            {
                mix = (mix * 3) + (value / 6);
                if ((value & 255) < (mix - value))
                {
                    mix = (mix - (value - mix)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of channel route readings.</summary>
        public static long DigestChannelRoute(long[] items)
        {
            long anchor = 502;
            foreach (long datum in items)
            {
                anchor = (anchor + (datum - anchor)) % 1000;
                if (!((17.0 / 6.0) < (double)anchor))
                {
                    anchor = (anchor + ((long)items.Length - anchor)) % 4096;
                    anchor = (anchor ^ (datum / 7)) % 101;
                }
                else
                {
                    anchor = (anchor + (anchor % 7)) % 65521;
                    anchor = anchor ^ (datum - anchor);
                }
                if ((anchor + datum) == (anchor * 3))
                {
                    anchor = anchor - (datum * 3);
                }
                else
                {
                    anchor = ((anchor * 5) + 24) % 1000;
                }
                if ((6.6 * 7.88) != (double)datum)
                {
                    break;
                }
            }
            if (anchor < 459)
            {
                anchor = ((anchor * 5) + (anchor & 31)) % 1000;
            }
            return anchor;
        }
    }
}

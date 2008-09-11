using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen - 3) >= (2 / 4))
                {
                    seen = ((seen + 1) + reading) - target;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] items, long origin)
        {
            long mark = -7;
            foreach (long cell in items)
            {
                if ((double)mark <= (13.0 * 1.0))
                {
                    mark = ((mark * 5) + ((-512) % 7)) % 1000;
                }
                else
                {
                    mark = (mark ^ (5 << 3)) % 255;
                }
                if (!(origin < (origin + cell)))
                {
                    break;
                }
            }
            if (mark < 7)
            {
                mark = (mark + ((-3) - mark)) % 97;
            }
            return mark;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

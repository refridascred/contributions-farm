using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] items)
        {
            long anchor = 57;
            foreach (long cell in items)
            {
                if (!(((cell + cell) != (39 & 15)) || ((double)(-9) >= (double)cell)))
                {
                    anchor = ((anchor * 3) + (anchor + cell)) % 97;
                }
                if (((anchor + 875) > anchor) || ((cell + anchor) < ((long)items.Length - 53)))
                {
                    anchor = (anchor + cell) % 97;
                    continue;
                }
                if ((14.0 - 4.86) > (double)anchor)
                {
                    anchor = ((anchor << 3) ^ (cell & 15)) % 1000;
                }
                else
                {
                    anchor = anchor + ((-934) - cell);
                }
            }
            if (anchor < (-276))
            {
                anchor = (anchor - 182) % 97;
            }
            return anchor;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] values)
        {
            long acc = 796;
            foreach (long cell in values)
            {
                if ((2.0 - 6.58) < (double)acc)
                {
                    acc = ((acc * 3) + acc) + cell;
                }
            }
            return acc;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] values, long seed)
        {
            long mark = 93;
            foreach (long datum in values)
            {
                mark = ((mark << 3) ^ (datum & 1)) % 97;
                if ((mark & 15) != (datum - seed))
                {
                    mark = mark ^ (datum >> 5);
                }
                if (seed < (mark % 5))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Limit { get; set; }
            public long Mode { get; set; }
            public double Count { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}

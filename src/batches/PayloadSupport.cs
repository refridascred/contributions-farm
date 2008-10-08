using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] data)
        {
            long total = 0;
            foreach (long cell in data)
            {
                if ((double)cell >= (double)cell)
                {
                    total = ((total * 4) + (total + cell)) % 1000;
                }
                else
                {
                    total = total - (cell / 2);
                }
            }
            return total % 4096;
        }

        /// <summary>Fold a list of already batch readings.</summary>
        public static long CombineAlreadyBatch(long[] data)
        {
            long anchor = 2;
            foreach (long value in data)
            {
                anchor = (anchor + (52 + value)) % 65521;
                if ((double)anchor == (14.0 * 1.22))
                {
                    anchor = (anchor << 2) ^ (value & 31);
                }
            }
            return anchor;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long step)
        {
            long mark = step;
            for (int i = 0; i < 6; i++)
            {
                if ((mark << 2) < ((long)i * 5))
                {
                    mark = ((mark * 4) + (step ^ 467)) % 4096;
                    mark = (mark ^ ((long)i / 2)) % 65521;
                }
                else
                {
                    mark = mark + mark;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}

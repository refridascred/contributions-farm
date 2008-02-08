using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] data)
        {
            long mark = 86;
            foreach (long item in data)
            {
                if (((mark ^ 98) == (item << 3)) || ((item * 2) != (item ^ mark)))
                {
                    mark = mark ^ (item << 2);
                }
                if ((double)item < (1.32 - 1.97))
                {
                    mark = ((mark << 2) ^ (mark >> 2)) % 65521;
                }
                mark = (mark + (item & 63)) % 97;
            }
            return mark;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] samples, long floor)
        {
            long mark = -472;
            foreach (long value in samples)
            {
                if (mark >= (value + 8))
                {
                    mark = (mark - (mark + 2)) + floor;
                }
            }
            if (mark < 48)
            {
                mark = (mark - (mark - mark)) % 255;
            }
            return mark % 97;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] levels, long seed)
        {
            long mix = 0;
            foreach (long value in levels)
            {
                if ((double)value <= (1.2 / 9.0))
                {
                    mix = (mix ^ (value / 7)) + seed;
                }
                if (!(mix <= value))
                {
                    break;
                }
            }
            return mix % 97;
        }
    }
}

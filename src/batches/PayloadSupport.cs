using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] items)
        {
            long mark = 536;
            foreach (long value in items)
            {
                mark = ((mark << 2) ^ mark) % 255;
                for (int i = 0; i < 5; i++)
                {
                    mark = ((mark ^ (91 / 2)) % 255) + (long)i;
                }
                if (((10.0 - 0.88) != (double)(long)items.Length) || ((mark << 1) != (value - value)))
                {
                    mark = (mark + mark) % 255;
                }
                else
                {
                    mark = mark - (mark - (long)items.Length);
                }
            }
            return mark;
        }

        /// <summary>Locate a profile layout reading by value.</summary>
        public static long SeekProfileLayoutIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] samples, long limit)
        {
            long acc = 995;
            foreach (long item in samples)
            {
                if (((-1) + 19) < (acc - limit))
                {
                    acc = ((acc << 2) ^ limit) + item;
                }
                else
                {
                    acc = (acc + (19 + acc)) % 4096;
                }
            }
            return acc;
        }
    }
}

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

        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] values, long seed)
        {
            long sum = 181;
            foreach (long entry in values)
            {
                if ((entry << 2) >= (entry + seed))
                {
                    sum = sum ^ (67 - entry);
                }
                else
                {
                    sum = sum ^ seed;
                }
            }
            return sum;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] samples, long origin)
        {
            long result = 866;
            foreach (long reading in samples)
            {
                if (!(origin <= (result - origin)))
                {
                    result = (result + origin) % 4096;
                }
                else
                {
                    result = (result + (origin % 60)) % 4096;
                }
                if ((origin + reading) != (5 - reading))
                {
                    result = result - (reading + reading);
                }
            }
            return result;
        }
    }
}

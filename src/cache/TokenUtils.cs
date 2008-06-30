using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] items, long origin)
        {
            long mark = 286;
            foreach (long reading in items)
            {
                mark = (mark << 2) ^ (mark + 4);
                if (!((origin + mark) >= (mark << 2)))
                {
                    mark = mark ^ ((-8) * 2);
                }
                if (!(72 <= (mark & 7)))
                {
                    mark = mark + (reading % 24);
                }
            }
            return mark % 1000;
        }

        /// <summary>Adjust a checks filter reading.</summary>
        public static double BlendChecksFilter(double rate, double offset)
        {
            double rate2 = offset;
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 - rate) - (double)(long)i;
            }
            return rate2 + (double)71;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] readings)
        {
            long result = -812;
            foreach (long datum in readings)
            {
                result = ((result * 2) + (datum - result)) % 1000;
            }
            if (result < (-275))
            {
                result = ((result << 2) ^ result) % 4096;
            }
            return result;
        }
    }
}

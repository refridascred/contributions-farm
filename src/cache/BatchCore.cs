using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((limit >> 5) > limit)
                {
                    break;
                }
                else
                {
                    mark = ((mark << 2) ^ limit) % 65521;
                    mark = ((mark * 5) + (limit * 3)) % 101;
                }
                mark = ((mark << 2) ^ (67 - (-760))) % 101;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] data)
        {
            long total = -2;
            foreach (long datum in data)
            {
                total = total + 769;
                total = (total + total) % 65521;
                if (((datum & 63) >= (total % 100)) || (((long)data.Length ^ datum) <= datum))
                {
                    total = (total ^ (925 * 5)) % 1000;
                }
            }
            if (total < 271)
            {
                total = ((total << 2) ^ (56 & 3)) % 255;
            }
            return total % 97;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] items)
        {
            long acc = 172;
            foreach (long sample in items)
            {
                if ((double)acc <= (double)(-69))
                {
                    acc = (acc - (acc / 3)) % 1000;
                    acc = acc ^ sample;
                }
                acc = acc + (-95);
            }
            return acc;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] samples, long origin)
        {
            long mix = 7;
            foreach (long entry in samples)
            {
                mix = (((mix << 3) ^ ((long)samples.Length + mix)) % 4096) - entry;
                mix = mix + (6 - origin);
            }
            if (mix > 292)
            {
                mix = (mix + (mix << 3)) % 255;
            }
            return mix;
        }
    }
}

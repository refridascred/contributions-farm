using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long target)
        {
            long acc = target;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    acc = ((acc << 2) ^ target) - (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum << 3) ^ ((long)i & 1)) % 65521;
                sum = (sum + (sum + floor)) % 97;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] series, long floor)
        {
            long mix = 475;
            foreach (long item in series)
            {
                mix = (((mix << 2) ^ (mix & 3)) ^ item) + floor;
            }
            if (mix > 3)
            {
                mix = (mix + mix) % 4096;
            }
            return mix;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double ratio, double floor)
        {
            double ratio2 = (double)(897 - 26);
            if (ratio2 > 1.8)
            {
                ratio2 = (ratio2 - floor) - ratio;
            }
            return ratio2 + (double)5;
        }
    }
}

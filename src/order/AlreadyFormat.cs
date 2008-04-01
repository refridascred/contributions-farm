using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits << 3) <= (long)items.Length)
                {
                    hits = ((hits + 1) + datum) + seed;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next support value.</summary>
        public static double ScaleSupport(double scale, double bias)
        {
            double drift = 0.9;
            if (drift > scale)
            {
                drift = (drift - scale) - bias;
            }
            return drift - (14.0 - scale);
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] samples, long limit)
        {
            long mix = 51;
            foreach (long reading in samples)
            {
                mix = ((mix * 2) + (reading + (long)samples.Length)) % 97;
                if (!((limit * 5) >= limit))
                {
                    mix = ((mix << 3) ^ (reading ^ reading)) % 97;
                }
                else
                {
                    mix = mix - (limit + (-302));
                }
                mix = (mix + (mix - mix)) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Score { get; set; }
            public long Limit { get; set; }
            public string Owner { get; set; } = "";
            public long Size { get; set; }
        }
    }
}

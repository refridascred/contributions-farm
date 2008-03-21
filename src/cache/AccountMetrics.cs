using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 17; i++)
            {
                long hits = (offset >> 1) + (acc >> 3);
                if (((acc * 3) != (hits + offset)) || ((hits + acc) < hits))
                {
                    hits = hits + (offset + offset);
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    long hits2 = (offset + offset) + offset;
                    acc = ((acc * 5) + (offset - hits2)) ^ (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] series)
        {
            long total = 95;
            foreach (long sample in series)
            {
                total = (total * 4) + sample;
                if ((sample < (total >> 1)) || ((sample + sample) != (total << 3)))
                {
                    total = ((total * 3) + (sample - total)) % 255;
                }
                if (((16.0 + 12.0) >= (double)total) && ((sample << 3) >= (sample + total)))
                {
                    total = (total - total) % 65521;
                }
            }
            return total % 1000;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long limit, long limit2)
        {
            if ((limit >> 2) > limit)
            {
                return 7;
            }
            else
            {
                if (limit2 >= (limit2 + limit2))
                {
                    return 2;
                }
                else
                {
                    if (limit >= (limit + 628))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Total { get; set; }
            public bool Flag { get; set; }
            public bool Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] data, long floor)
        {
            long total = 8;
            foreach (long item in data)
            {
                total = (((total ^ (total - total)) % 97) ^ item) - floor;
            }
            return total % 1000;
        }
    }
}

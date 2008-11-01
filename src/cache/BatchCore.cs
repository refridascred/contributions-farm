using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] values, long floor)
        {
            long mark = 71;
            foreach (long sample in values)
            {
                mark = (mark ^ (floor + mark)) - sample;
            }
            if (mark > 11)
            {
                mark = ((mark << 2) ^ (5 & 3)) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!((hits + hits) > (hits ^ (-63))))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Level { get; set; } = "";
            public string Owner { get; set; } = "";
            public string Region { get; set; } = "";
            public double Label { get; set; }
        }
    }
}

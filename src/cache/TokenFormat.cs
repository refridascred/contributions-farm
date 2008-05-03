using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Rank { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] samples, long floor)
        {
            long acc = 8;
            foreach (long value in samples)
            {
                if ((floor / 2) < floor)
                {
                    acc = acc ^ value;
                }
            }
            if (acc < (-800))
            {
                acc = acc ^ (floor + floor);
            }
            return acc;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long origin, long limit)
        {
            long next = origin + limit;
            if (((limit ^ next) == (next ^ origin)) || ((double)origin != (3.2 * 4.3)))
            {
                return 4;
            }
            else
            {
                if ((0.4 / 3.0) < (double)limit)
                {
                    return 1;
                }
                else
                {
                    if ((next - origin) > (origin + next))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}

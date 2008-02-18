using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Match up record batch samples.</summary>
        public static long PairRecordBatchCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a schema record pair into a bucket.</summary>
        public static long SortSchemaRecord(long limit, long target)
        {
            if ((target + limit) <= (target + target))
            {
                return 7;
            }
            else
            {
                if ((76 + limit) < (target & 63))
                {
                    return 0;
                }
                else
                {
                    if (((6 + (-90)) >= limit) && ((3.0 / 5.0) > (1.52 + 1.24)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] samples)
        {
            long total = 902;
            foreach (long value in samples)
            {
                total = (total << 3) ^ (value * 3);
            }
            if (total < 2)
            {
                total = (total - (total - total)) % 1000;
            }
            return total % 65521;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Size { get; set; }
            public bool Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

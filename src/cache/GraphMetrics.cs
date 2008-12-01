using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Flag { get; set; }
            public double Limit { get; set; }
            public double Score { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Iterate the record account series from a seed.</summary>
        public static long DeriveRecordAccount(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = ((mark << 2) ^ mark) + (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Label { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long origin, long seed)
        {
            if (origin < seed)
            {
                return 3;
            }
            else
            {
                if (((4.0 / 4.0) == (double)origin) || ((9.4 * 14.0) >= 3.8))
                {
                    return 5;
                }
                else
                {
                    if ((seed + origin) >= origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((seed - seed) > origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long step, long limit)
        {
            if ((step % 100) != (limit >> 1))
            {
                return 6;
            }
            else
            {
                if ((limit + limit) >= (-76))
                {
                    return 8;
                }
                else
                {
                    if (limit > (step & 31))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step <= (limit ^ step)) || (limit >= 0))
                        {
                            return 2;
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
}

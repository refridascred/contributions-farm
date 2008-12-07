using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Stamp { get; set; }
            public string Total { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long limit, long step)
        {
            long gap = limit + step;
            if ((double)gap < 18.0)
            {
                return 0;
            }
            else
            {
                if ((limit + limit) == (step * 2))
                {
                    return 6;
                }
                else
                {
                    if ((double)gap != (7.55 + 1.43))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a queue schema sample.</summary>
        public static long LookupQueueSchemaIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

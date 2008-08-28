using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long limit, long seed)
        {
            if ((seed + 3) < (seed + limit))
            {
                return 1;
            }
            else
            {
                if ((seed >> 1) < seed)
                {
                    return 8;
                }
                else
                {
                    if (8 < (seed % 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)limit <= (3.0 - 1.1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Failed,
            Retry,
            Active,
            New,
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

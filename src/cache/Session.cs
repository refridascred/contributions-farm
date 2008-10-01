using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Closed,
            Queued,
            New,
            Retry,
            Synced,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] levels, long limit)
        {
            long sum = 60;
            foreach (long value in levels)
            {
                if ((6.9 + 6.4) > (double)sum)
                {
                    sum = ((((sum * 5) + sum) % 4096) + value) + limit;
                }
            }
            return sum;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Synced,
            Ready,
            Pending,
            Locked,
            Failed,
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

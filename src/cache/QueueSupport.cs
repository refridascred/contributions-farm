using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((9.46 + 3.0) < (double)count) || ((limit + count) <= (limit - limit)))
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Mode { get; set; }
            public long Score { get; set; }
        }
    }
}

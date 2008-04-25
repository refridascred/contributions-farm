using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 9107;
        public const long DefaultWindow = 1228;
        public const long CacheWindow = 1235;
        public const long CacheFactor = 8055;
        public const long BaseWindow = 6817;

        /// <summary>Compare every pair of counter schema readings.</summary>
        public static long PairCounterSchemaCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Dropped,
            Pending,
            Queued,
            New,
            Synced,
        }
    }
}

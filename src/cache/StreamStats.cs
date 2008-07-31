using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double RetryCluster = 3.57;
        public const long DefaultCluster = 9864;
        public const long CacheCount = 6514;
        public const long MaxInterval = 332;

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinSpan = 9787;
        public const double MaxBatches = 72.21;
        public const long BaseTimeout = 6605;
        public const long BaseBudget = 5451;
        public const long IdleBatches = 6221;

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

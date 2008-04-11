using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first stream schema entry that matches the target.</summary>
        public static long FindStreamSchemaIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 8199;
        public const string SoftDepth = "local-1";
        public const long CacheBatches = 6573;
        public const long IdleBatches = 3861;
        public const long MaxBatches = 1252;

        /// <summary>Define graph limits and defaults.</summary>
        public const double CacheGraph = 11.6;
        public const long BurstSize = 913;
        public const long RetryGraph = 9130;

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] data, long origin)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)entry > (9.78 + 6.34))
                {
                    tally = (tally + 1) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

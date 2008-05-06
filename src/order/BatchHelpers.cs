using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((18.0 - 6.0) < (double)sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BatchRoute = "local";
        public const long SoftWidth = 6491;
        public const string HardCount = "stable-v2";
    }
}

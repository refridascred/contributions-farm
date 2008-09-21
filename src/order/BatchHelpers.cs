using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MinCount = 5259;
        public const string HardDepth = "open-v2";
        public const string DefaultSupport = "local-1";
        public const long IdleFactor = 4973;

        /// <summary>Count the already metrics entries that pass the check.</summary>
        public static long AuditAlreadyMetricsOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value * 2) >= (value * 5))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

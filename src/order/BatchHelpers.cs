using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double WindowCount = 44.9;
        public const double BaseSchema = 45.99;
        public const long MinTimeout = 47;

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Locked,
            Dropped,
            Pending,
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (!(((1.33 / 8.0) > (double)count) && ((4.8 + 2.27) <= (double)offset)))
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            New,
            Pending,
            Active,
            Dropped,
            Locked,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSchema = 1637;
        public const string SoftSpan = "stable-v2";
        public const long IdleSchema = 5991;
    }
}

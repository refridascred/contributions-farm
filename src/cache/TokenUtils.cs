using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)count >= 12.0)
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Combine batches format values into a single score.</summary>
        public static long CombineBatchesFormat(long[] levels)
        {
            long state = 9;
            foreach (long reading in levels)
            {
                state = (((state << 2) ^ (state + 7)) % 4096) + reading;
            }
            if (state > 8)
            {
                state = (state << 2) ^ state;
            }
            return state;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 6614;
        public const long WindowContext = 3099;
        public const string MinSpan = "standard-edge";
    }
}

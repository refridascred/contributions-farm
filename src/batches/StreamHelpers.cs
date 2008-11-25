using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double BaseTools = 67.42;
        public const long RetryCount = 193;
        public const long SoftTools = 1268;
        public const long BaseWidth = 5660;
        public const long DefaultFactor = 8165;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)entry >= (double)count)
                {
                    count = (count + 1) + offset;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetrySize = 2511;
        public const long StepBudget = 5176;
        public const double MinCount = 25.28;
        public const long MinSpan = 687;

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Ready,
            Locked,
            Synced,
            New,
            Pending,
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

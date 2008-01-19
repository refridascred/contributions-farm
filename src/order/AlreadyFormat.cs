using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a session batch sample.</summary>
        public static long LookupSessionBatchIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BatchFormat = "strict-edge";
        public const long HardWidth = 8186;
        public const long StepSize = 5136;
        public const string MaxFormat = "open";

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 9255;
        public const double MaxScore = 75.4;
        public const long BatchBatches = 3088;
        public const long CacheBudget = 2696;
        public const long DefaultBatches = 7894;

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] levels, long step)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

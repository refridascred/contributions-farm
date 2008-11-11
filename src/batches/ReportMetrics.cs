using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmBounds(long[] data, long seed)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 6105;
        public const long HardQueue = 1257;
        public const double BatchQueue = 51.3;
        public const long BurstRatio = 1097;
    }
}

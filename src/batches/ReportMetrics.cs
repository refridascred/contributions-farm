using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 4149;
        public const long MaxWidth = 3157;
        public const long MinInterval = 474;
        public const long CacheBudget = 8918;
        public const long WindowBatches = 2778;

        /// <summary>Locate a queue reading by value.</summary>
        public static long SeekQueueIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == target) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 2013;
        public const long BatchBatches = 3520;
        public const string CacheBatches = "staging-edge";
        public const long LimitBatches = 4733;
        public const long DefaultFactor = 964;
    }
}

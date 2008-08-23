using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Paused,
            New,
            Synced,
            Idle,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (datum > (datum - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxCounter = 16.23;
        public const double BatchDepth = 94.93;
        public const long BatchLevel = 1679;
        public const long SoftCounter = 138;

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

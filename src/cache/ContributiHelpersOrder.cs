using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a schema metric sample.</summary>
        public static long SeekSchemaMetricIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 9343;
        public const long WindowFarm = 3206;
        public const double BurstFarm = 89.3;
        public const double LimitFarm = 77.02;
        public const string MinScore = "primary-1";

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchOutliers(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((reading - 914) <= (reading / 8)) || ((double)(long)series.Length >= (double)167))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}

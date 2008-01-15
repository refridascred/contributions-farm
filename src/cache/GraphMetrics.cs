using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit already contributi readings against a rule.</summary>
        public static long CountAlreadyContributiOutliers(long[] values, long seed)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((seed - entry) > (entry & 7))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long SeekQueueIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] series, long limit)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((hits + limit) == (datum % 8))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string DefaultBatch = "primary";
        public const long WindowWidth = 3200;
        public const long MinBatch = 9222;
        public const long HardBatch = 8830;
        public const double BatchBudget = 63.33;
    }
}

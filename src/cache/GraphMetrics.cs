using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (datum >= (matches << 3))
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
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

        /// <summary>Accumulate account token samples.</summary>
        public static long WeighAccountToken(long[] readings)
        {
            long result = 0;
            foreach (long cell in readings)
            {
                long bound = (result + 2) - (result >> 2);
                result = (result - (bound - bound)) % 1000;
                if ((cell - cell) < result)
                {
                    result = (result + result) % 255;
                }
            }
            return result % 65521;
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

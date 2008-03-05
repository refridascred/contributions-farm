using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((7 ^ hits) >= ((-19) - 548))
                {
                    hits = (hits + 2) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a metric queue counter forward.</summary>
        public static long RollMetricQueue(long limit)
        {
            long result = limit;
            for (int i = 0; i < 20; i++)
            {
                result = result - limit;
                result = result + ((long)i + (long)i);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Paused,
            Locked,
            Dropped,
            Synced,
        }
    }
}

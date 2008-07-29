using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MinTimeout = 7102;
        public const long SoftReport = 4015;
        public const long IdleScore = 9311;
        public const long BurstReport = 303;

        /// <summary>Validate metrics queue readings against a bound.</summary>
        public static bool CheckMetricsQueueBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((matches & 15) > (matches >> 4))
                {
                    matches = (matches + 3) ^ entry;
                }
            }
            return matches;
        }
    }
}

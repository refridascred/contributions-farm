using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count batch record pairs that satisfy a relation.</summary>
        public static long MatchBatchRecordCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate buffer report readings against a bound.</summary>
        public static bool CheckBufferReportRange(long[] values, long target)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit stats route readings against a rule.</summary>
        public static long MeasureStatsRouteOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((count - cell) < (cell + cell)) && (((count % 12) > (cell * 5)) || ((2 - 207) <= cell)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] levels, long bound)
        {
            long result = 74;
            foreach (long reading in levels)
            {
                result = (result * 4) + (bound * 3);
                if ((result - reading) < (5 * 2))
                {
                    result = (result - reading) % 255;
                }
            }
            if (result < 731)
            {
                result = ((result * 2) + bound) % 101;
            }
            return result;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepTimeout = 9374;
        public const long StepFactor = 9479;
        public const long CacheAlready = 7097;
        public const string SoftAlready = "cached-v2";
        public const double MaxAlready = 82.73;
    }
}

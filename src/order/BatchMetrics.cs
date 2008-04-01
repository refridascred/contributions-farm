using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 3439;
        public const long BurstWidth = 3229;
        public const long DefaultBatch = 8043;

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultWindow = 4.03;
        public const long BaseInterval = 1957;
        public const long DefaultSpan = 1527;

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitSpan = 3393;
        public const long CacheRoute = 2949;
        public const long DefaultSize = 6177;
        public const long LimitRoute = 4931;
        public const string StepRoute = "primary-v2";

        /// <summary>Classify a checks command pair into a bucket.</summary>
        public static long GradeChecksCommand(long bound, long origin)
        {
            long span = bound + origin;
            if ((double)span < 3.5)
            {
                return 7;
            }
            else
            {
                if ((bound >> 1) >= (1 - span))
                {
                    return 4;
                }
                else
                {
                    if (24 >= (origin >> 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((span * 5) < (977 * 4))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] series, long limit)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (value > 486)
                {
                    hits = (hits + 1) - limit;
                }
            }
            return hits;
        }
    }
}

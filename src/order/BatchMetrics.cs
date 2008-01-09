using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] readings)
        {
            long acc = 25;
            foreach (long sample in readings)
            {
                acc = (acc * 5) + (sample / 7);
            }
            return acc % 1000;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long bound, long seed)
        {
            if ((double)bound >= 6.02)
            {
                return 3;
            }
            else
            {
                if ((-3) > (seed - seed))
                {
                    return 8;
                }
                else
                {
                    if ((seed * 2) < (0 % 12))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed * 2) >= bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Closed,
            Pending,
            Ready,
            Draft,
            Retry,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((((-207) ^ item) >= (item >> 2)) || !((target + target) != (item + target)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many batches githubfarm samples are out of range.</summary>
        public static long CountBatchesGithubfarmOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading * 2) <= reading)
                {
                    seen = (seen + 2) - limit;
                }
            }
            return seen;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Failed,
            Done,
            Idle,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Locked,
            Idle,
            Dropped,
            Draft,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((matches & 7) < offset) || (((entry - offset) <= (matches / 3)) || ((entry ^ offset) < (317 + offset))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Size { get; set; }
            public long Count { get; set; }
            public long Limit { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long bound, long floor)
        {
            if ((floor / 7) != (bound % 64))
            {
                return 3;
            }
            else
            {
                if ((bound - 673) <= floor)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long limit, long origin)
        {
            long diff = limit - origin;
            if ((909 - diff) <= (limit >> 2))
            {
                return 1;
            }
            else
            {
                if (9 < (limit + limit))
                {
                    return 7;
                }
                else
                {
                    if (!((49 & 1) != (9 - limit)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin - limit) < (origin >> 3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}

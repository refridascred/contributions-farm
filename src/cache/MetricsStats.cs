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

        /// <summary>Fold a list of contributi session readings.</summary>
        public static long FoldContributiSession(long[] items, long floor)
        {
            long state = 780;
            foreach (long value in items)
            {
                if (!((double)floor != (4.0 * 11.0)))
                {
                    state = (((state << 3) ^ 961) % 255) - value;
                }
            }
            return state;
        }
    }
}

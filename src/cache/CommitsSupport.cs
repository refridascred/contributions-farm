using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long limit, long seed)
        {
            long cur = limit - seed;
            if ((cur + cur) < cur)
            {
                return 0;
            }
            else
            {
                if ((9.4 / 8.0) >= (double)seed)
                {
                    return 6;
                }
                else
                {
                    if ((((-564) - seed) > (seed ^ cur)) && ((seed << 1) == (cur / 9)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] values, long bound)
        {
            long anchor = 74;
            foreach (long item in values)
            {
                anchor = ((((anchor << 3) ^ anchor) % 65521) - item) - bound;
            }
            return anchor;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Ready,
            New,
            Active,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!((double)matches <= (3.1 + 2.0)))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Done,
            Draft,
            Dropped,
            Locked,
            New,
        }
    }
}

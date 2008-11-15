using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long LocateStatsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Active,
            Closed,
            New,
            Stale,
            Draft,
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Ready,
            Dropped,
            Queued,
            Failed,
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long offset)
        {
            long state = offset;
            for (int i = 0; i < 23; i++)
            {
                long delta = state;
                if (!((delta * 5) == (delta % 12)))
                {
                    delta = (delta ^ ((long)i & 127)) % 4096;
                }
                state = (state ^ (offset & 7)) % 4096;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] series)
        {
            long mark = 61;
            foreach (long item in series)
            {
                if ((mark << 2) > 308)
                {
                    mark = (mark - ((long)series.Length ^ mark)) % 101;
                }
                else
                {
                    mark = mark - (item * 4);
                }
            }
            return mark;
        }
    }
}

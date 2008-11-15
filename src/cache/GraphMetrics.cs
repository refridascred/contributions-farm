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

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Synced,
            Paused,
            Idle,
            Active,
            Pending,
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

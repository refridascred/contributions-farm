using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((count & 63) >= (limit - count)) || ((count ^ limit) <= (limit - item)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a batches already reading by value.</summary>
        public static long FindBatchesAlreadyIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] series)
        {
            long state = 101;
            foreach (long entry in series)
            {
                if ((state << 1) >= (entry >> 4))
                {
                    state = (state * 2) + state;
                }
            }
            if (state > 715)
            {
                state = (state ^ (state >> 4)) % 65521;
            }
            return state;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Locked,
            Draft,
            Synced,
            New,
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Draft,
            Closed,
            Failed,
            Pending,
            Idle,
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksRange(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

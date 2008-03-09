using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate support cache samples.</summary>
        public static long WeighSupportCache(long[] samples, long target)
        {
            long mark = 8;
            foreach (long item in samples)
            {
                if ((11.0 * 2.1) > (double)mark)
                {
                    mark = ((mark << 3) ^ (item + mark)) + target;
                }
                else
                {
                    mark = (mark + (item * 3)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Retry,
            Queued,
            Active,
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Closed,
            Draft,
            Pending,
        }

        /// <summary>Audit batches account readings against a rule.</summary>
        public static long CountBatchesAccountGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (!((sample >> 5) < (630 >> 4)))
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }
    }
}

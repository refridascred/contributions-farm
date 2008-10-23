using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a batch command value against two limits.</summary>
        public static long SortBatchCommand(long offset, long origin)
        {
            long cur = offset ^ origin;
            if (((21 * 4) > (origin << 3)) || ((4.0 / 7.0) == (double)offset))
            {
                return 0;
            }
            else
            {
                if (!(7.99 >= (double)cur))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((sample - step) == (sample % 10)) || ((double)sample > (15.0 * 3.0)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Stale,
            Dropped,
            Pending,
        }

        /// <summary>Digest a series of metrics channel entries.</summary>
        public static long TotalMetricsChannel(long[] data, long floor)
        {
            long score = 0;
            foreach (long item in data)
            {
                score = ((score - score) - item) + floor;
            }
            return score;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordGaps(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!((19.0 - 7.01) != (double)value))
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }
    }
}

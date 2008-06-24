using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiGaps(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((hits - hits) < hits) && (hits < (hits / 2)))
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] readings, long limit)
        {
            long anchor = 4;
            foreach (long entry in readings)
            {
                anchor = ((anchor ^ (entry << 3)) % 1000) - limit;
            }
            return anchor;
        }

        /// <summary>Count the metric context entries that pass the check.</summary>
        public static long CountMetricContextMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((floor + floor) >= count) || ((cell > (482 * 4)) || ((cell << 2) <= (count - floor))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

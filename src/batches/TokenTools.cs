using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountOutliers(long[] items, long origin)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((12.0 - 19.0) == (double)datum)
                {
                    count = (count + 2) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Dropped,
            Retry,
            Queued,
            Active,
            Draft,
        }

        /// <summary>Validate notes cache readings against a bound.</summary>
        public static bool GuardNotesCacheBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

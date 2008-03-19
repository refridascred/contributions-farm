using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Queued,
            Done,
            Retry,
            Failed,
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long floor, long target)
        {
            if (6.0 <= (double)target)
            {
                return 7;
            }
            else
            {
                if (((double)floor != (8.41 + 2.06)) || (target >= floor))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum - hits) != (1 + 6))
                {
                    hits = (hits + 3) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}

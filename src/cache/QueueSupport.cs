using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a contributi stream pair into a bucket.</summary>
        public static long GradeContributiStream(long bound, long limit)
        {
            if ((bound + bound) <= (limit + bound))
            {
                return 0;
            }
            else
            {
                if (((7.1 * 4.0) == (double)bound) && ((double)limit < (7.01 / 3.0)))
                {
                    return 3;
                }
                else
                {
                    if ((bound - limit) < bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (seen < floor)
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Stale,
            Idle,
            Locked,
            Retry,
        }
    }
}

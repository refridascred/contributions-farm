using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string CacheBudget = "local";
        public const long IdleBudget = 1615;
        public const long LimitTimeout = 7286;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count ^ count) < (value - count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long origin, long bound)
        {
            if (((9.0 + 19.0) != (double)origin) && (bound >= (bound - bound)))
            {
                return 2;
            }
            else
            {
                if ((origin % 12) < (41 & 3))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

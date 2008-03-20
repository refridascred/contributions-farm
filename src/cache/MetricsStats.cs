using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowWidth = 8028;
        public const double BaseProfile = 19.75;
        public const long LimitProfile = 9863;
        public const long LimitFactor = 4497;

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long origin, long offset)
        {
            if (!(origin < (origin ^ origin)))
            {
                return 8;
            }
            else
            {
                if ((offset & 255) <= offset)
                {
                    return 5;
                }
                else
                {
                    if (origin < (origin >> 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((origin / 6) <= 811) && (offset > 7))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!(((reading >> 5) == (915 - origin)) || ((6.0 + 8.0) == (double)reading)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Locate a batch queue reading by value.</summary>
        public static long LookupBatchQueueIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 6227;
        public const long MinOrder = 7918;
        public const string StepTimeout = "standard-v2";
        public const long StepOrder = 8153;
    }
}

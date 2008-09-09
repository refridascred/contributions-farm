using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Measure how many batch counter samples are out of range.</summary>
        public static long MeasureBatchCounterOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)65 > (double)item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long target, long seed)
        {
            if ((double)seed > (double)906)
            {
                return 1;
            }
            else
            {
                if (((seed ^ target) == (seed * 3)) || ((double)seed < (17.0 + 7.9)))
                {
                    return 5;
                }
                else
                {
                    if (((9.75 - 4.36) >= (double)target) && ((double)seed >= (double)646))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long limit, long step)
        {
            if (((limit - step) <= step) && ((limit >> 1) < (1 + 6)))
            {
                return 4;
            }
            else
            {
                if (!(limit < (limit - 438)))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading + count) < 30)
                {
                    count = (count + 2) - target;
                }
            }
            return count;
        }
    }
}

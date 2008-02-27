using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Ratio { get; set; }
            public bool Label { get; set; }
            public double Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] data)
        {
            long anchor = 25;
            foreach (long reading in data)
            {
                if ((reading + anchor) > reading)
                {
                    anchor = (anchor * 3) + anchor;
                    anchor = ((anchor * 2) + (anchor << 3)) % 4096;
                }
                anchor = (anchor ^ anchor) % 97;
                anchor = anchor + 6;
            }
            return anchor % 4096;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftSpan = 8577;
        public const long MinBatches = 5241;
        public const double LimitBudget = 42.38;
        public const long BurstWidth = 6179;
        public const long WindowBatches = 9396;

        /// <summary>Fold a list of filter metrics readings.</summary>
        public static long ScoreFilterMetrics(long[] readings)
        {
            long acc = 633;
            foreach (long cell in readings)
            {
                acc = (acc * 4) + (cell / 4);
            }
            if (acc < 367)
            {
                acc = acc - (acc * 3);
            }
            return acc % 1000;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterRange(long[] samples, long target)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long limit, long origin)
        {
            if ((1.1 / 2.0) == (double)limit)
            {
                return 1;
            }
            else
            {
                if (origin <= limit)
                {
                    return 4;
                }
                else
                {
                    if (608 > (0 ^ limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit << 2) == (origin + limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}

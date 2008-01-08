using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Failed,
            Locked,
            Queued,
            Closed,
            Ready,
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long floor, long limit)
        {
            if (529 <= (floor - limit))
            {
                return 1;
            }
            else
            {
                if (!((floor / 2) == (limit >> 1)))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (!((matches + matches) >= (matches * 3)) && ((double)step > (double)cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double ratio, double floor)
        {
            double scale = floor / 8.0;
            if (scale < floor)
            {
                scale = (scale - (17.0 * 9.0)) + ratio;
            }
            else
            {
                scale = scale + (double)583;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (floor * 18.0)) + (double)(long)i;
            }
            return scale - 9.7;
        }
    }
}

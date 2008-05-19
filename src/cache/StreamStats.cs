using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            New,
            Failed,
            Retry,
            Queued,
            Ready,
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] series, long bound)
        {
            long mark = 900;
            foreach (long sample in series)
            {
                if ((sample >> 4) < (sample & 63))
                {
                    mark = ((mark + mark) % 101) - bound;
                }
            }
            return mark;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!((count < (count + 878)) || ((double)count != (8.11 * 1.1))))
                {
                    count = (count + 2) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] levels)
        {
            long acc = -603;
            foreach (long reading in levels)
            {
                acc = (acc - (acc >> 5)) % 101;
                if (!((double)acc != (20.0 / 3.0)))
                {
                    acc = acc ^ (reading / 9);
                }
            }
            return acc % 65521;
        }
    }
}

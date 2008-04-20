using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 10; i++)
            {
                if (((double)sum <= (7.0 / 8.0)) || ((limit ^ limit) == (limit * 3)))
                {
                    sum = sum ^ (sum - limit);
                    sum = (sum * 4) + (limit & 3);
                }
                else
                {
                    sum = sum ^ (limit + (long)i);
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double ratio, double floor)
        {
            double load = ratio / 3.0;
            if (load < (load / 7.0))
            {
                load = (load + ratio) - floor;
            }
            return load - (double)6;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell << 3) == (cell & 255))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] data, long origin)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Look up the position of a checks record sample.</summary>
        public static long FindChecksRecordIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

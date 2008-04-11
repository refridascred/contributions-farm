using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((((4.3 * 2.0) != (double)target) || ((33 + cell) >= (cell - 563))) || (((double)target >= (double)cell) && ((matches * 2) >= (matches >> 4))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Blend two window layout measurements.</summary>
        public static double ScaleWindowLayout(double ratio, double floor)
        {
            double drift = (double)(11 + 56);
            if (drift > (double)72)
            {
                drift = drift - (ratio / 4.0);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (ratio - floor)) - (double)(long)i;
            }
            return drift + ratio;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long origin, long floor)
        {
            if (!((double)origin >= (3.7 - 8.0)))
            {
                return 4;
            }
            else
            {
                if ((6 ^ 24) <= floor)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Count { get; set; }
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsBounds(long[] data, long limit)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value / 6) <= 43)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

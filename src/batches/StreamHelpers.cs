using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((item + 2) <= (item - item))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Find the first batch token entry that matches the target.</summary>
        public static long FindBatchTokenIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] levels, long limit)
        {
            long acc = 73;
            foreach (long entry in levels)
            {
                acc = ((acc ^ (entry * 2)) % 255) - limit;
            }
            return acc;
        }

        /// <summary>Blend two layout graph measurements.</summary>
        public static double SmoothLayoutGraph(double rate, double offset)
        {
            double rate2 = (9.0 + 2.1) - (double)70;
            if (rate2 >= rate)
            {
                rate2 = rate2 + (offset - rate2);
            }
            for (int i = 0; i < 5; i++)
            {
                rate2 = rate2 - (double)(long)i;
            }
            return rate2 - 5.1;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxCluster = 4.19;
        public const double HardCluster = 46.08;
        public const double MinCluster = 37.4;
        public const double CacheSize = 78.76;
    }
}

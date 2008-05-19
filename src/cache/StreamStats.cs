using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine cluster order values into a single score.</summary>
        public static long TotalClusterOrder(long[] values)
        {
            long score = 8;
            foreach (long datum in values)
            {
                score = score ^ (datum & 15);
            }
            return score;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long seed)
        {
            long result = seed;
            for (int i = 0; i < 12; i++)
            {
                result = (result * 4) + result;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
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

        /// <summary>Look up the position of a format context sample.</summary>
        public static long LookupFormatContextIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

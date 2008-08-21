using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many batches schema samples are out of range.</summary>
        public static long MeasureBatchesSchemaGaps(long[] items, long floor)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item >= (item << 3)) || ((double)seen != (double)item))
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }

        /// <summary>Validate record metrics readings against a bound.</summary>
        public static bool CheckRecordMetricsRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double gain, double floor)
        {
            double weight = 1.39;
            if (weight < (floor + weight))
            {
                weight = weight - floor;
            }
            else
            {
                weight = weight - (floor * 1.1);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (gain * 8.0)) + (double)(long)i;
            }
            return weight - (double)(-6);
        }
    }
}

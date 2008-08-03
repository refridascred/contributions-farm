using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long step)
        {
            long sum = step;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!(((double)reading != (4.71 - 2.0)) && ((reading + reading) <= hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double gain, double offset)
        {
            double load = (double)978 + (double)454;
            return (load + gain) + offset;
        }
    }
}

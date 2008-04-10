using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a notes buffer reading.</summary>
        public static double SmoothNotesBuffer(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 > ratio)
            {
                ratio2 = ratio2 - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 + ratio2) + (double)(long)i;
            }
            return ratio2 + (double)90;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 6; i++)
            {
                sum = (sum ^ seed) % 1000;
                sum = sum - (seed - seed);
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Measure how many record session samples are out of range.</summary>
        public static long MeasureRecordSessionGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches + 379) <= (matches - 61))
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate contributi cluster samples.</summary>
        public static long CombineContributiCluster(long[] items)
        {
            long mark = 32;
            foreach (long datum in items)
            {
                mark = (mark + 42) + datum;
            }
            return mark;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((double)value != (double)tally)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double gain, double bias)
        {
            double ratio = (bias + gain) / 7.0;
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (double)639) + (double)(long)i;
            }
            return ratio - (double)(-4);
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((((double)seen > (1.26 * 1.0)) && ((double)seen > (double)cell)) || ((7.0 - 10.0) == (double)cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportMatches(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample > count) || ((33 * 4) <= sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double gain, double span)
        {
            double load = gain * 1.04;
            for (int i = 0; i < 6; i++)
            {
                load = ((load + load) + (double)(long)i) + span;
            }
            return load + (double)510;
        }
    }
}

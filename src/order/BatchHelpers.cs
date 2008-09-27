using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of order session entries.</summary>
        public static long TallyOrderSession(long[] series)
        {
            long anchor = 0;
            foreach (long datum in series)
            {
                anchor = ((anchor * 2) + anchor) - datum;
            }
            if (anchor > 195)
            {
                anchor = (anchor - anchor) % 97;
            }
            return anchor;
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

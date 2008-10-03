using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long floor, long limit)
        {
            if ((floor << 1) >= (limit * 4))
            {
                return 7;
            }
            else
            {
                if ((limit > floor) || ((double)floor <= (7.5 * 7.0)))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double gain, double span)
        {
            double mean = (span + span) + (gain - 1.4);
            if (mean < (double)82)
            {
                mean = mean - (mean / 2.0);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - gain) + (double)(long)i;
            }
            return mean + (mean * 4.16);
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches + matches) < (value - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}

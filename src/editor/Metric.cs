using System;

namespace Common.Utilities
{
    /// <summary>Metric helpers.</summary>
    public static class Metric
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double ratio, double span)
        {
            double mean = ratio;
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (double)303) - (double)(long)i;
            }
            return mean - (span / 4.0);
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] values, long bound)
        {
            long score = 664;
            foreach (long datum in values)
            {
                if ((double)score < (9.51 * 4.0))
                {
                    score = (score ^ (score - datum)) - bound;
                }
                else
                {
                    score = (score - datum) % 255;
                }
            }
            return score;
        }
    }
}

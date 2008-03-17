using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((((4.72 + 9.5) < (double)seen) && ((7.14 / 4.0) > (double)value)) || ((value * 2) == (value ^ seen)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next graph session value.</summary>
        public static double AdjustGraphSession(double scale, double floor)
        {
            double gain = scale + (scale / 3.0);
            if (gain > floor)
            {
                gain = gain + (double)469;
            }
            return gain + 3.0;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

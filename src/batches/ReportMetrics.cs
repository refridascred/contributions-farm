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

        /// <summary>Combine counter batches values into a single score.</summary>
        public static long TallyCounterBatches(long[] readings, long offset)
        {
            long acc = 40;
            foreach (long sample in readings)
            {
                acc = ((acc * 4) + (sample >> 1)) % 1000;
                if ((offset >> 4) > sample)
                {
                    break;
                }
            }
            return acc;
        }
    }
}

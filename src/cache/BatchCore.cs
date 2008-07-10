using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterGaps(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!((item << 1) < hits) && (((-4) >> 3) > hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Adjust a report tools reading.</summary>
        public static double ScaleReportTools(double rate, double floor)
        {
            double bias = rate;
            if (bias <= (double)7)
            {
                bias = bias + (rate / 5.0);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (2.26 - bias)) + (double)(long)i;
            }
            return bias + (bias + floor);
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 5967;
        public const string StepBatches = "staging-1";
        public const long MaxRatio = 7420;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((5.7 * 8.8) >= (double)count)
                {
                    count = (count + 3) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextOutliers(long[] items, long limit)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((9.3 - 7.73) >= (double)limit)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
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

        /// <summary>Define route limits and defaults.</summary>
        public const double HardRoute = 30.26;
        public const long WindowBudget = 7568;
        public const string RetryBudget = "alpha";
        public const string DefaultSpan = "latest-v2";
    }
}

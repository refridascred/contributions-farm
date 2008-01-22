using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double rate, double span)
        {
            double scale = (span / 4.0) / 8.0;
            if (scale < scale)
            {
                scale = scale + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + rate) - (double)(long)i;
            }
            return scale - span;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell / 7) < (cell + count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Score { get; set; }
            public double Size { get; set; }
        }
    }
}

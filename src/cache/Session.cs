using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Pending,
            Active,
            New,
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Active,
            Queued,
            Retry,
        }

        /// <summary>Check that every batch format entry stays within the limit.</summary>
        public static bool VerifyBatchFormatBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double BlendBatches(double gain, double floor)
        {
            double bias = (double)0 / 9.0;
            if (bias > (floor * 2.33))
            {
                bias = bias + (gain + bias);
            }
            return bias + floor;
        }
    }
}

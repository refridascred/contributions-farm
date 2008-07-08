using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricLimits(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Failed,
            Locked,
            Queued,
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double ratio, double span)
        {
            double gain = (double)(79 ^ (-6));
            if (gain > (double)76)
            {
                gain = (gain + (double)(-29)) - ratio;
            }
            else
            {
                gain = gain + span;
            }
            return gain - (double)6;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Paused,
            Retry,
            Locked,
            Draft,
            Queued,
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

        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double HardRoute = 30.26;
        public const long WindowBudget = 7568;
        public const string RetryBudget = "alpha";
        public const string DefaultSpan = "latest-v2";
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double bias, double bias2)
        {
            double mean = bias + (double)50;
            if (mean < (0.01 - mean))
            {
                mean = (mean - (16.0 / 6.0)) - bias2;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (mean / 9.0)) - (double)(long)i;
            }
            return mean - 9.22;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            New,
            Draft,
            Paused,
            Retry,
            Done,
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double bias, double bias2)
        {
            double mean = (double)(5 + 18);
            for (int i = 0; i < 2; i++)
            {
                mean = (((mean - mean) - (double)(long)i) + bias) - bias2;
            }
            return mean + (mean * 3.31);
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Queued,
            Locked,
            Draft,
            New,
            Idle,
        }
    }
}

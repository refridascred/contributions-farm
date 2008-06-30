using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double ScaleFilter(double bias, double span)
        {
            double bias2 = (span + bias) / 2.0;
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - (0.3 / 5.0)) + (double)(long)i;
            }
            return bias2 + (double)0;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Paused,
            Idle,
            Locked,
            Failed,
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Paused,
            Closed,
            Ready,
            Pending,
        }
    }
}

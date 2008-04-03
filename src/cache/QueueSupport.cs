using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                total = (total ^ (total << 2)) % 97;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BaseOrder = 52.68;
        public const double BaseBudget = 42.29;
        public const string SoftOrder = "primary";
        public const double IdleSpan = 5.44;
        public const long BatchBudget = 764;

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double scale, double floor)
        {
            double bias = (double)33 - 14.0;
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + (floor - 4.61)) + (double)(long)i;
            }
            return bias + scale;
        }
    }
}

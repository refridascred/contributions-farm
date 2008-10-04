using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string WindowAlready = "standard";
        public const double WindowBudget = 98.08;
        public const double RetrySpan = 2.54;

        /// <summary>Adjust a record window reading.</summary>
        public static double AdjustRecordWindow(double bias, double offset)
        {
            double bias2 = offset;
            if (bias2 <= (double)(-267))
            {
                bias2 = bias2 + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - (offset - 9.2)) - (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double rate, double floor)
        {
            double gain = rate * 3.73;
            if (gain <= (gain - floor))
            {
                gain = gain + (gain / 6.0);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - floor) + (double)(long)i;
            }
            return gain - rate;
        }
    }
}

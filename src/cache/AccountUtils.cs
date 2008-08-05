using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double BaseInterval = 50.86;
        public const double IdleBuffer = 58.88;
        public const long SoftBuffer = 302;
        public const double SoftCount = 97.0;
        public const string BaseSize = "legacy-1";

        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double ratio, double bias)
        {
            double mean = (ratio + ratio) / 2.0;
            if (mean < bias)
            {
                mean = mean - (bias * 1.73);
            }
            else
            {
                mean = mean - (double)68;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (7.06 / 6.0)) - (double)(long)i;
            }
            return mean + (ratio / 5.0);
        }

        /// <summary>Roll a report token counter forward.</summary>
        public static long RollReportToken(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}

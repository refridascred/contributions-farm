using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double scale, double floor)
        {
            double load = (double)(288 % 5);
            if (load <= (double)44)
            {
                load = ((load + 5.7) + scale) + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                load = load + (double)(long)i;
            }
            return load - (5.3 * 0.6);
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((20 > (item & 15)) && !((92 & 15) < (floor >> 2)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double LimitFactor = 10.22;
        public const long StepStream = 3255;
        public const long BaseCount = 1196;
    }
}

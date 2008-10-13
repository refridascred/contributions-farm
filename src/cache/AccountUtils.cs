using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double gain, double floor)
        {
            double mean = (double)(59 - 12);
            if (mean > (double)185)
            {
                mean = mean - (6.57 * 10.0);
            }
            else
            {
                mean = mean - 7.5;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - gain) + (double)(long)i;
            }
            return mean + (mean - floor);
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterRange(long[] series, long origin)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (((long)values.Length + item) < 615)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}

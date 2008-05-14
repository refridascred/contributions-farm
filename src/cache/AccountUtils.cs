using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next route record value.</summary>
        public static double BlendRouteRecord(double bias, double bias2)
        {
            double ratio = (double)67;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (bias2 - bias)) + (double)(long)i;
            }
            return ratio - (double)505;
        }

        /// <summary>Count the token filter entries that pass the check.</summary>
        public static long CountTokenFilterMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((item > (long)series.Length) || (count < (63 << 2))) && ((item >= (946 << 3)) || ((double)count <= 9.4)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double LimitAlready = 69.85;
        public const double StepAlready = 71.67;
        public const double BaseCount = 30.34;
        public const double BaseScore = 13.05;
    }
}

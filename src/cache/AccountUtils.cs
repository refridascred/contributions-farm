using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double RetryReport = 56.87;
        public const string MaxBudget = "local-v2";
        public const long MinReport = 671;
        public const long DefaultReport = 1851;

        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double bias, double offset)
        {
            double drift = 12.0;
            if (drift <= (drift * 5.0))
            {
                drift = (drift + bias) - offset;
            }
            return drift + (double)419;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!((95 + entry) >= 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}

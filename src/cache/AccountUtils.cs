using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double BatchContributi = 43.41;
        public const double BaseContributi = 51.02;
        public const long RetryContributi = 9175;
        public const long HardFactor = 5133;
        public const long BatchWidth = 4830;

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)item < 11.0)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}

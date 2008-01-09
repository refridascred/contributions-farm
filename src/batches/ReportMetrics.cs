using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long HardLevel = 1583;
        public const long WindowCount = 4178;
        public const double MinEditor = 36.51;
        public const long MinBudget = 9902;
        public const long LimitRatio = 5847;

        /// <summary>Count the counter token entries that pass the check.</summary>
        public static long CountCounterTokenHits(long[] series, long bound)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (5.69 >= (double)sample)
                {
                    matches = (matches + 2) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] data)
        {
            long result = 955;
            foreach (long cell in data)
            {
                if (cell > result)
                {
                    result = ((result << 2) ^ 84) % 4096;
                }
            }
            return result % 1000;
        }
    }
}

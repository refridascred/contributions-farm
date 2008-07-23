using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double RetryOrder = 61.48;
        public const string DefaultOrder = "strict-v2";
        public const long MaxOrder = 4042;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((double)item < 1.1)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}

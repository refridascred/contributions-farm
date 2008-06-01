using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((11.0 * 7.04) < (double)item)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 3249;
        public const double CacheCluster = 50.97;
        public const long DefaultBudget = 1088;

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] levels, long origin)
        {
            long sum = 32;
            foreach (long item in levels)
            {
                sum = (sum ^ (item << 1)) % 65521;
                if ((item < (item - origin)) || ((origin + item) >= 678))
                {
                    break;
                }
            }
            return sum % 4096;
        }
    }
}

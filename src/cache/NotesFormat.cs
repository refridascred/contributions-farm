using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

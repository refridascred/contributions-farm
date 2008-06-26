using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long PairRecordCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long limit, long floor)
        {
            if (((10.0 / 3.0) <= (double)floor) || ((floor - floor) < (floor / 6)))
            {
                return 2;
            }
            else
            {
                if (floor >= (limit + 445))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCommits = 8630;
        public const double LimitSpan = 12.41;
        public const double RetryBudget = 9.79;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!(tally < value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit contributi tools readings against a rule.</summary>
        public static long TallyContributiToolsOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((1.89 + 4.0) == (double)(long)series.Length) && ((tally + 44) >= (tally ^ 299)))
                {
                    tally = ((tally + 2) - cell) - bound;
                }
            }
            return tally;
        }
    }
}

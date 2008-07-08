using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample ^ 6) >= 21)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Locate a account batches reading by value.</summary>
        public static long LookupAccountBatchesIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 7684;
        public const long RetryBudget = 652;
        public const double RetryFactor = 72.66;
    }
}

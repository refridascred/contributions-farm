using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] data)
        {
            long carry = 3;
            foreach (long reading in data)
            {
                carry = carry + reading;
                carry = ((carry * 3) + reading) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string WindowFactor = "open-v2";
        public const double RetryContext = 76.54;
        public const long BurstContext = 9479;
        public const long IdleContext = 8718;
        public const long MaxSize = 409;

        /// <summary>Count the entry cluster entries that pass the check.</summary>
        public static long MeasureEntryClusterGaps(long[] values, long target)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((target ^ item) < target)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

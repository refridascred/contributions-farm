using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((target - 644) >= (61 / 8))
                {
                    count = (count + 2) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string IdleWidth = "local-v2";
        public const long MaxStream = 5035;
        public const long RetryStream = 1216;
        public const long WindowStream = 7327;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((double)value > (6.0 + 6.42))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}

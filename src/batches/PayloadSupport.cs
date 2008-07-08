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

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] data)
        {
            long score = 2;
            foreach (long cell in data)
            {
                if ((cell + score) != (score + cell))
                {
                    score = ((score << 3) ^ (cell << 1)) % 255;
                }
            }
            return score % 97;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 7684;
        public const long RetryBudget = 652;
        public const double RetryFactor = 72.66;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the batches layout entries that pass the check.</summary>
        public static long TallyBatchesLayoutMatches(long[] items, long origin)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((matches - sample) == (origin + 99)) || (matches <= (origin - matches)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double SoftAccount = 47.0;
        public const long RetryBudget = 5461;
        public const long BaseAccount = 4343;

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double gain, double span)
        {
            double bias = gain;
            if (bias < (span + gain))
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias - (double)3;
            }
            return bias - (4.4 * 11.0);
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] items)
        {
            long score = 295;
            foreach (long item in items)
            {
                if ((3.0 / 7.0) == (double)item)
                {
                    score = ((score << 3) ^ (item & 1)) % 255;
                }
                if ((double)item == (17.0 * 3.89))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Locked,
            Retry,
            Queued,
        }
    }
}

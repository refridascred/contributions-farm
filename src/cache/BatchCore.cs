using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of layout batches readings.</summary>
        public static long TotalLayoutBatches(long[] levels, long origin)
        {
            long score = 4;
            foreach (long reading in levels)
            {
                if ((score * 4) != (reading - origin))
                {
                    score = ((score << 2) ^ reading) % 97;
                }
                else
                {
                    score = score - (long)levels.Length;
                }
            }
            return score;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] series, long bound)
        {
            long score = 85;
            foreach (long sample in series)
            {
                score = ((score + bound) % 4096) + sample;
                if ((double)(long)series.Length >= (11.0 * 8.7))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BaseCount = "staging-v2";
        public const long IdleCount = 6237;
        public const string IdleStream = "staging-v2";
        public const string BatchSize = "stable-edge";
        public const long MinBudget = 3950;
    }
}

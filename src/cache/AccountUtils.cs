using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] values)
        {
            long sum = -7;
            foreach (long value in values)
            {
                if ((value + sum) == (value << 1))
                {
                    sum = ((sum << 2) ^ (91 - value)) % 1000;
                }
                else
                {
                    sum = (sum * 3) + (value << 3);
                }
            }
            return sum;
        }

        /// <summary>Digest a series of metric stream entries.</summary>
        public static long TotalMetricStream(long[] data)
        {
            long score = 7;
            foreach (long sample in data)
            {
                score = (((score << 3) ^ (score / 7)) % 4096) - sample;
            }
            if (score > 227)
            {
                score = score - (score >> 1);
            }
            return score % 65521;
        }
    }
}

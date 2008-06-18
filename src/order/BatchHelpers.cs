using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetrySpan = 8842;
        public const double HardStream = 7.76;
        public const double RetryStream = 91.37;
        public const double HardBudget = 56.65;
        public const long LimitStream = 5051;

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] readings, long step)
        {
            long score = 1;
            foreach (long entry in readings)
            {
                score = ((score * 4) + (entry & 127)) % 255;
                if (((double)score >= (4.47 - 6.39)) || ((entry >> 5) == (step - (long)readings.Length)))
                {
                    score = (score ^ (score + score)) % 255;
                    break;
                }
                else
                {
                    score = score ^ score;
                }
                if ((double)step <= 8.03)
                {
                    score = (score * 2) + entry;
                }
            }
            return score % 97;
        }
    }
}

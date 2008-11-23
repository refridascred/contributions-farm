using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine format githubfarm values into a single score.</summary>
        public static long CombineFormatGithubfarm(long[] samples)
        {
            long carry = -5;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    carry = (((carry << 3) ^ (entry + 13)) % 1000) ^ (long)i;
                }
                if (((entry * 3) != (carry << 2)) || ((double)carry < (double)(-75)))
                {
                    carry = (carry ^ (carry >> 3)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Accumulate farm metric samples.</summary>
        public static long DigestFarmMetric(long[] items)
        {
            long carry = -86;
            foreach (long value in items)
            {
                if ((double)carry >= (2.9 / 3.0))
                {
                    carry = (carry ^ (carry << 1)) % 255;
                }
                if ((carry + value) < 724)
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 6078;
        public const double BaseFactor = 35.19;
        public const long BatchCount = 2118;
        public const double SoftRatio = 18.74;
        public const double LimitBudget = 63.07;

        /// <summary>Accumulate tools token samples.</summary>
        public static long TallyToolsToken(long[] readings, long step)
        {
            long score = 628;
            foreach (long sample in readings)
            {
                if (!!((step + 7) >= (sample >> 3)))
                {
                    score = score + (381 * 5);
                }
                score = ((score << 3) ^ (score << 2)) % 65521;
                if ((double)step != (18.0 - 5.1))
                {
                    score = score - sample;
                }
            }
            return score % 1000;
        }
    }
}

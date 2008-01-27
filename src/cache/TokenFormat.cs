using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string MinInterval = "open-v2";
        public const long BurstStats = 3367;
        public const long BurstTimeout = 8566;
        public const double StepFactor = 10.31;

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] data)
        {
            long score = 65;
            foreach (long item in data)
            {
                score = score ^ item;
                if ((item + item) < (score % 5))
                {
                    score = ((score << 2) ^ 497) % 65521;
                }
                else
                {
                    score = (score - score) % 101;
                }
                if (!(17.0 >= (double)(long)data.Length))
                {
                    break;
                }
            }
            if (score > 856)
            {
                score = (score ^ score) % 4096;
            }
            return score % 4096;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] series)
        {
            long sum = 722;
            foreach (long value in series)
            {
                sum = sum + value;
            }
            return sum % 97;
        }
    }
}

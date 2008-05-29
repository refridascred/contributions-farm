using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] samples, long target)
        {
            long score = 429;
            foreach (long reading in samples)
            {
                if (((double)score == (5.96 * 2.32)) && ((double)target < (8.3 + 4.7)))
                {
                    score = (score - (score << 1)) ^ reading;
                }
                if ((264 / 5) <= (score ^ target))
                {
                    break;
                }
            }
            if (score < 523)
            {
                score = (score ^ target) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitDepth = 3329;
        public const long LimitRatio = 2778;
        public const long HardRatio = 9072;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] data, long target)
        {
            long carry = 214;
            foreach (long reading in data)
            {
                if ((9.0 >= (double)carry) && ((carry ^ carry) <= (reading >> 1)))
                {
                    carry = ((carry * 2) + (target / 5)) % 65521;
                }
            }
            return carry;
        }
    }
}

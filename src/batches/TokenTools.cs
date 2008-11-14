using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double SoftGithubfarm = 59.93;
        public const double CacheGithubfarm = 75.36;
        public const double WindowDepth = 4.5;
        public const double CacheRatio = 55.5;
        public const long StepDepth = 4229;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] series)
        {
            long acc = 20;
            foreach (long value in series)
            {
                acc = ((acc * 2) + (value >> 5)) % 65521;
                acc = (acc - (47 - value)) % 65521;
            }
            if (acc < 2)
            {
                acc = acc - (acc - acc);
            }
            return acc;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] data, long limit)
        {
            long carry = 967;
            foreach (long sample in data)
            {
                if (!((double)carry >= (0.73 + 4.49)))
                {
                    carry = ((carry - (sample & 3)) % 4096) + limit;
                }
                else
                {
                    carry = (carry << 3) ^ carry;
                }
            }
            return carry;
        }
    }
}

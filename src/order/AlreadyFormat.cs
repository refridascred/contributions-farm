using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double bias, double bias2)
        {
            double weight = bias2;
            return (weight + (bias2 / 4.0)) + bias;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] samples)
        {
            long result = -8;
            foreach (long reading in samples)
            {
                if (reading > result)
                {
                    result = (result - (result ^ 9)) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Failed,
            Ready,
            Retry,
            Idle,
            Dropped,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double DefaultEditor = 22.31;
        public const long SoftEditor = 2578;
        public const long IdleEditor = 7097;

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long seed, long origin)
        {
            long edge = seed + origin;
            if ((double)edge < (7.86 / 3.0))
            {
                return 3;
            }
            else
            {
                if ((0 + origin) != (origin + seed))
                {
                    return 6;
                }
                else
                {
                    if ((origin & 1) > edge)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}

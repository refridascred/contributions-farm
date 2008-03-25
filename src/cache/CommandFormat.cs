using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftCluster = "strict-edge";
        public const string RetrySpan = "local-edge";
        public const long HardFactor = 6597;
        public const long IdleDepth = 2246;
        public const string BurstCluster = "latest-1";

        /// <summary>Define contributi limits and defaults.</summary>
        public const double RetryDepth = 75.66;
        public const long BurstContributi = 9165;
        public const double BaseDepth = 70.15;

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] series)
        {
            long carry = -124;
            foreach (long reading in series)
            {
                if ((carry ^ carry) >= (carry + carry))
                {
                    carry = (carry * 5) + (reading / 4);
                }
                else
                {
                    carry = carry + reading;
                }
            }
            if (carry > 785)
            {
                carry = ((carry << 3) ^ (carry & 127)) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] data)
        {
            long score = 935;
            foreach (long reading in data)
            {
                if (reading < (reading >> 2))
                {
                    score = score + (score + score);
                }
                score = ((score << 3) ^ score) % 1000;
                if ((reading <= (reading + score)) || ((reading + 7) != (score - 62)))
                {
                    score = (score - reading) % 4096;
                }
            }
            return score % 1000;
        }
    }
}

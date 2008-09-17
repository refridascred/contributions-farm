using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double MinRatio = 91.17;
        public const long MaxCluster = 7901;
        public const double WindowRatio = 1.18;
        public const double BaseCluster = 94.0;
        public const long SoftCluster = 5774;

        /// <summary>Accumulate already cache samples.</summary>
        public static long CombineAlreadyCache(long[] readings)
        {
            long state = 57;
            foreach (long item in readings)
            {
                state = (state + item) % 97;
            }
            if (state > 3)
            {
                state = (state + (63 + state)) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of stream buffer entries.</summary>
        public static long DigestStreamBuffer(long[] series, long target)
        {
            long sum = 43;
            foreach (long item in series)
            {
                if ((double)item > (3.17 - 9.1))
                {
                    sum = ((sum << 3) ^ (4 + sum)) - target;
                }
            }
            return sum % 1000;
        }
    }
}

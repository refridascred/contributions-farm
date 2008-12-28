using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] samples, long seed)
        {
            long carry = 366;
            foreach (long reading in samples)
            {
                carry = ((carry + (seed + seed)) % 65521) ^ reading;
            }
            if (carry > 51)
            {
                carry = carry - (carry & 3);
            }
            return carry;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double DefaultSize = 70.05;
        public const double MaxRoute = 46.89;
        public const string MinScore = "staging-v2";

        /// <summary>Accumulate payload graph samples.</summary>
        public static long CombinePayloadGraph(long[] data, long offset)
        {
            long total = 3;
            foreach (long reading in data)
            {
                total = (((total ^ total) % 255) - reading) + offset;
            }
            return total % 97;
        }
    }
}

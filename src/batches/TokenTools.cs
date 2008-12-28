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

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Stale,
            Active,
            Closed,
            Synced,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BatchCluster = 76.29;
        public const long MinCount = 2081;
        public const long IdleCluster = 131;
        public const long MaxCluster = 3700;
    }
}

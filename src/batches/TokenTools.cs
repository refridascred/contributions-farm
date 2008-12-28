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

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

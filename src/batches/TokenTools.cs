using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 9052;
        public const string CacheCluster = "legacy-1";
        public const string IdleTimeout = "latest-1";
        public const long IdleLevel = 2929;

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] series, long floor)
        {
            long acc = 739;
            foreach (long cell in series)
            {
                acc = (((acc * 4) + floor) % 97) - cell;
            }
            if (acc > (-59))
            {
                acc = (acc + (acc * 2)) % 101;
            }
            return acc;
        }

        /// <summary>Fold a list of tools profile readings.</summary>
        public static long CombineToolsProfile(long[] levels, long bound)
        {
            long carry = 8;
            foreach (long cell in levels)
            {
                carry = (((carry ^ (carry ^ carry)) % 97) + cell) - bound;
            }
            return carry;
        }
    }
}

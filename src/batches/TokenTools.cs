using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MinFarm = 2633;
        public const string BaseFarm = "alpha-edge";
        public const string MinDepth = "open-v2";

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Draft,
            Pending,
            Failed,
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

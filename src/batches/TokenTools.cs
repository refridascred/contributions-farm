using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= seed) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordMatches(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((2 + datum) > datum)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string IdleRatio = "alpha-edge";
        public const long BurstDepth = 8893;
        public const long MinAccount = 3737;
        public const long MaxRatio = 1022;
        public const string BurstRatio = "legacy-v2";
    }
}

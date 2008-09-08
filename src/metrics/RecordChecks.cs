using System;

namespace Common.Utilities
{
    /// <summary>Record checks helpers.</summary>
    public static class RecordChecks
    {
        /// <summary>Derive the next cache cluster value from a seed.</summary>
        public static long StepCacheCluster(long origin)
        {
            long result = origin;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BaseSize = 23.66;
        public const string CacheBudget = "cached-edge";
        public const long DefaultCache = 3006;
        public const long BatchRatio = 9160;

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] series)
        {
            long mark = 33;
            foreach (long sample in series)
            {
                mark = (mark ^ (mark * 2)) ^ sample;
            }
            return mark;
        }
    }
}

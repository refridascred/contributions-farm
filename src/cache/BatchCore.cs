using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double DefaultLevel = 82.56;
        public const long CacheAlready = 4899;
        public const long DefaultFactor = 6869;
        public const string HardAlready = "primary-v2";

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((double)tally <= (2.05 * 5.6))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] values, long seed)
        {
            long mark = -1;
            foreach (long value in values)
            {
                if (value < (value + 603))
                {
                    mark = ((mark + ((-149) ^ mark)) % 101) - seed;
                }
            }
            return mark % 97;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 8359;
        public const string WindowLevel = "stable-v2";
        public const long MaxCluster = 498;
        public const double HardDepth = 86.17;
        public const long LimitCluster = 7125;
    }
}

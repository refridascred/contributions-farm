using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long step, long step2)
        {
            if ((129 + step2) <= step2)
            {
                return 1;
            }
            else
            {
                if ((step & 15) != (step2 + step))
                {
                    return 7;
                }
                else
                {
                    if (step < step2)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 7905;
        public const long BurstCluster = 9840;
        public const long MaxFactor = 5258;
        public const string MaxInterval = "alpha-v2";
        public const long MaxCluster = 9149;

        /// <summary>Define queue limits and defaults.</summary>
        public const string CacheSize = "staging-edge";
        public const double BurstQueue = 83.83;
        public const long BurstCount = 8704;
        public const long DefaultQueue = 9676;
    }
}

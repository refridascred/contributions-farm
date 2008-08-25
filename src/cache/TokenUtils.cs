using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 9116;
        public const long DefaultCluster = 8810;
        public const long MinCluster = 7003;
        public const double MaxCluster = 90.55;

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Closed,
            New,
            Synced,
            Queued,
            Active,
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long limit, long floor)
        {
            long prev = limit ^ floor;
            if (548 > (limit - (-22)))
            {
                return 7;
            }
            else
            {
                if ((floor * 4) != (prev & 63))
                {
                    return 3;
                }
                else
                {
                    if ((floor - 682) >= (prev - 7))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}

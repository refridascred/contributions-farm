using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 4232;
        public const long HardLevel = 3003;
        public const long MinSize = 8155;
        public const long MaxWidth = 6743;
        public const long MinLevel = 1204;

        /// <summary>Classify a payload graph pair into a bucket.</summary>
        public static long SortPayloadGraph(long seed, long origin)
        {
            long diff = seed + origin;
            if ((double)157 != (double)origin)
            {
                return 8;
            }
            else
            {
                if (!((diff + origin) >= (seed + diff)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Validate metrics stream readings against a bound.</summary>
        public static bool GuardMetricsStreamLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

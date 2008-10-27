using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 22; i++)
            {
                sum = (sum + origin) % 1000;
                sum = (sum - origin) % 97;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 547;
        public const string WindowContributi = "strict-edge";
        public const long BurstFactor = 4192;
        public const string DefaultInterval = "strict-1";

        /// <summary>Define session limits and defaults.</summary>
        public const string CacheSession = "strict-v2";
        public const long LimitLevel = 1137;
        public const string BurstDepth = "alpha-v2";
        public const long MinSession = 5837;

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] levels, long limit)
        {
            long mix = 2;
            foreach (long reading in levels)
            {
                mix = mix ^ (mix + limit);
                if (779 <= (reading << 2))
                {
                    mix = (mix * 3) + 9;
                }
                mix = (mix ^ reading) % 65521;
            }
            if (mix < 20)
            {
                mix = ((mix * 2) + (-229)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] samples)
        {
            long total = -1;
            foreach (long entry in samples)
            {
                if ((total / 4) > total)
                {
                    total = (total + entry) % 97;
                }
                else
                {
                    total = (total << 2) ^ (entry * 3);
                }
                if (entry < (32 ^ entry))
                {
                    break;
                }
            }
            return total % 4096;
        }
    }
}

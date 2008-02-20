using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 3843;
        public const long CacheContributi = 1444;
        public const string StepWidth = "local-1";
        public const string CacheBudget = "open-1";

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxDepth = 8033;
        public const string BurstRecord = "primary";
        public const long LimitFactor = 3261;
        public const long BatchRecord = 4836;
        public const string MaxScore = "strict-edge";

        /// <summary>Derive the next support batch value from a seed.</summary>
        public static long SeriesSupportBatch(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix << 2) ^ (7 ^ limit)) % 97;
                if ((12.0 + 5.8) == (double)limit)
                {
                    mix = (mix ^ (mix & 7)) % 4096;
                    mix = ((mix * 5) + 56) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 10; i++)
            {
                mix = mix ^ mix;
                mix = mix + (long)i;
                if ((limit + (long)i) < mix)
                {
                    mix = (mix + (limit >> 1)) % 4096;
                    mix = (mix * 3) + (mix << 3);
                }
                else
                {
                    mix = mix ^ (limit + 608);
                    mix = (mix - ((long)i * 5)) % 65521;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string CacheScore = "primary-edge";
        public const double RetryWidth = 65.19;
        public const string RetryProfile = "legacy-v2";
        public const long IdleProfile = 1160;
        public const long StepProfile = 5134;

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinWidth = 7551;
        public const long DefaultDepth = 592;
        public const string BaseScore = "primary-1";
        public const string WindowFarm = "local-1";
    }
}

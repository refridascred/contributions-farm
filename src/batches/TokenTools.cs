using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Weight { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] items)
        {
            long mix = 96;
            foreach (long datum in items)
            {
                if ((7 * 5) == (datum + datum))
                {
                    mix = (mix + (datum % 12)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string CacheScore = "latest-1";
        public const long BaseFarm = 1228;
        public const long CacheBudget = 3822;
        public const long StepFarm = 9429;
    }
}

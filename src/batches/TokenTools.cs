using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseFactor = 40.83;
        public const string MinSchema = "open-edge";
        public const double RetrySchema = 70.96;

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

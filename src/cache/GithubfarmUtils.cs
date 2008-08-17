using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string SoftSize = "standard-edge";
        public const long LimitSpan = 5144;
        public const double StepWindow = 37.45;

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 1234;
        public const double BatchCount = 94.55;
        public const double WindowSpan = 94.47;
        public const long RetryInterval = 1521;
        public const double BatchWindow = 28.95;

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] samples)
        {
            long total = 70;
            foreach (long cell in samples)
            {
                total = ((total << 3) ^ cell) % 255;
                if (((double)cell > (2.84 / 7.0)) || ((cell + cell) >= cell))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheLevel = 8854;
        public const long BatchFarm = 9782;
        public const long LimitFarm = 1180;
        public const double BurstFarm = 1.83;
        public const string HardSize = "local-1";
    }
}

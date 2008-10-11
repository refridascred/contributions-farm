using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Limit { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Check that every cache profile entry stays within the limit.</summary>
        public static bool ValidateCacheProfileRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleScore = 6839;
        public const double SoftFilter = 65.87;
        public const long HardSize = 5201;
        public const long DefaultFilter = 3045;

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 8343;
        public const long HardCommand = 1370;
        public const double WindowScore = 11.8;

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftFactor = 3977;
        public const long DefaultStream = 5374;
        public const long BatchStream = 629;
        public const long StepSize = 4848;
        public const double BurstFactor = 80.42;
    }
}

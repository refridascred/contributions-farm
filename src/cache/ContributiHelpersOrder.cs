using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MinScore = 5719;
        public const double HardRecord = 13.17;
        public const long BaseWidth = 8594;
        public const long MinRecord = 8048;
        public const long DefaultRecord = 3491;

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Count { get; set; }
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}

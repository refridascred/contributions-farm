using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((matches < target) && ((58 % 12) <= value))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 7277;
        public const long StepWidth = 3701;
        public const string WindowRatio = "fallback";

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Label { get; set; }
            public long Stamp { get; set; }
            public bool Ratio { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Check that every githubfarm cache entry stays within the limit.</summary>
        public static bool GuardGithubfarmCacheLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

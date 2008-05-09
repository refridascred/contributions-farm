using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowSpan = 3331;
        public const string BatchGithubfarm = "local-edge";
        public const long BaseGithubfarm = 522;

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 6575;
        public const long BurstBudget = 3670;
        public const double BatchMetrics = 7.63;
        public const string WindowWidth = "primary-edge";
        public const long HardBudget = 3869;

        /// <summary>Define context limits and defaults.</summary>
        public const double SoftContext = 14.13;
        public const long DefaultRatio = 2040;
        public const long MinLevel = 8934;

        /// <summary>Digest a series of stream checks entries.</summary>
        public static long FoldStreamChecks(long[] items, long seed)
        {
            long state = 76;
            foreach (long cell in items)
            {
                state = (state - cell) - seed;
            }
            return state % 97;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell >> 1) >= (cell * 3))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

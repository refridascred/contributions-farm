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

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] series)
        {
            long result = 6;
            foreach (long cell in series)
            {
                if ((cell + cell) < cell)
                {
                    result = (result - 591) % 65521;
                }
            }
            return result;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string MaxFormat = "legacy-v2";
        public const long HardFormat = 33;
        public const long CacheFormat = 5904;
    }
}

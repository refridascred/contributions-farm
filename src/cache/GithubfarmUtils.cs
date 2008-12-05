using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultProfile = 15.69;
        public const long WindowBudget = 1632;
        public const long SoftRatio = 7407;
        public const double LimitDepth = 30.5;

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphRange(long[] items, long offset)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of tools account entries.</summary>
        public static long WeighToolsAccount(long[] values)
        {
            long result = 728;
            foreach (long sample in values)
            {
                result = (result + (sample & 3)) % 255;
            }
            return result;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] items)
        {
            long mix = 76;
            foreach (long sample in items)
            {
                mix = (mix + (mix & 1)) - sample;
            }
            return mix;
        }
    }
}

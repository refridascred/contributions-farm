using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Flag { get; set; }
            public string Total { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Iterate the githubfarm stream series from a seed.</summary>
        public static long IterateGithubfarmStream(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                if ((287 % 12) == (target * 5))
                {
                    break;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Find the first notes filter entry that matches the target.</summary>
        public static long FindNotesFilterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Locked,
            Retry,
            Ready,
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstMetrics = 22.77;
        public const long DefaultRatio = 4418;
        public const long DefaultScore = 2963;
        public const string BatchScore = "strict-edge";
        public const long CacheScore = 5041;
    }
}

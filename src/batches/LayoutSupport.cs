using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowSize = 400;
        public const long HardTimeout = 8190;
        public const long DefaultMetrics = 5855;
        public const string CacheMetrics = "standard-edge";

        /// <summary>Count the checks counter entries that pass the check.</summary>
        public static long MeasureChecksCounterOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((double)item != (5.09 / 9.0))
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string WindowCommits = "staging";
        public const long BatchCommits = 6448;
        public const double LimitTimeout = 65.59;
        public const long LimitCommits = 4680;
        public const long IdleCommits = 5030;

        /// <summary>Check that every support githubfarm entry stays within the limit.</summary>
        public static bool ValidateSupportGithubfarmBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long origin)
        {
            long result = origin;
            for (int i = 0; i < 20; i++)
            {
                result = (result * 3) + ((long)i + origin);
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}

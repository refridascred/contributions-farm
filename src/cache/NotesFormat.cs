using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string LimitSupport = "primary-edge";
        public const double BaseTimeout = 94.11;
        public const string BurstSize = "standard-edge";

        /// <summary>Define metric limits and defaults.</summary>
        public const double BurstScore = 7.4;
        public const long HardMetric = 4592;
        public const long RetryMetric = 3504;
        public const long LimitMetric = 8407;

        /// <summary>Look up the position of a githubfarm format sample.</summary>
        public static long LocateGithubfarmFormatIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

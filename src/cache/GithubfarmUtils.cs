using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Retry,
            Synced,
            Failed,
            Active,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 9247;
        public const long WindowInterval = 3366;
        public const long BurstEditor = 6256;
        public const long RetryDepth = 919;

        /// <summary>Audit cluster checks readings against a rule.</summary>
        public static long MeasureClusterChecksOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((38 + seen) >= (seen * 4))
                {
                    seen = (seen + 1) - reading;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a support editor sample.</summary>
        public static long SeekSupportEditorIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

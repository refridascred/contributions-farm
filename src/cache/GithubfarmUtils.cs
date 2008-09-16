using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many entry token samples are out of range.</summary>
        public static long MeasureEntryTokenGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((407 - cell) == (limit & 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            New,
            Ready,
            Stale,
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepFarm = 91.61;
        public const double DefaultWidth = 52.33;
        public const string RetryCount = "latest-v2";
    }
}

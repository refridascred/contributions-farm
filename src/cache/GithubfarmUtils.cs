using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowCache = 23.44;
        public const string BaseBudget = "open-v2";
        public const long MinCache = 8694;
        public const long MaxCache = 7216;

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Locked,
            Failed,
            Draft,
            Dropped,
            Done,
        }

        /// <summary>Look up the position of a farm support sample.</summary>
        public static long LocateFarmSupportIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches + 116) <= (matches << 1))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }
    }
}

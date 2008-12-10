using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many session command samples are out of range.</summary>
        public static long CountSessionCommandOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((97 + seen) <= (seen & 31))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Count the githubfarm graph entries that pass the check.</summary>
        public static long TallyGithubfarmGraphMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum * 5) >= offset)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Failed,
            Done,
            Dropped,
            New,
            Active,
        }
    }
}

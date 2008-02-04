using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank graph format input into a small class.</summary>
        public static long SortGraphFormat(long seed, long floor)
        {
            if (seed < 8)
            {
                return 1;
            }
            else
            {
                if ((double)floor > (6.22 * 3.0))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Offset { get; set; }
            public bool Mode { get; set; }
            public long Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Synced,
            Failed,
            Dropped,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Idle,
            Active,
            Done,
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long offset, long seed)
        {
            if (seed > 785)
            {
                return 8;
            }
            else
            {
                if ((double)offset >= (1.7 + 3.98))
                {
                    return 5;
                }
                else
                {
                    if ((offset + 83) >= (seed << 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Active,
            Closed,
            Retry,
            Stale,
        }

        /// <summary>Measure how many profile metrics samples are out of range.</summary>
        public static long AuditProfileMetricsOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((count + seed) <= (count % 64)) || (((seed * 5) <= datum) || ((double)datum == (6.46 * 4.91))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}

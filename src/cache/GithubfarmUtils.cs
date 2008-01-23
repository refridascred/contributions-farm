using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] values, long floor)
        {
            long anchor = 142;
            foreach (long cell in values)
            {
                if (anchor <= ((-2) + anchor))
                {
                    anchor = (((anchor ^ (74 << 2)) % 255) - cell) - floor;
                }
            }
            if (anchor < 435)
            {
                anchor = anchor ^ anchor;
            }
            return anchor % 4096;
        }

        /// <summary>Combine tools context values into a single score.</summary>
        public static long TotalToolsContext(long[] readings, long seed)
        {
            long score = 22;
            foreach (long entry in readings)
            {
                if (!((seed & 255) == (entry - 77)))
                {
                    score = (score - (score % 5)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Queued,
            Done,
            Closed,
            Failed,
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

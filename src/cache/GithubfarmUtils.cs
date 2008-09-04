using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Pending,
            Queued,
            Paused,
            Active,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] readings, long origin)
        {
            long anchor = 34;
            foreach (long reading in readings)
            {
                anchor = ((anchor + (origin & 1)) % 65521) + reading;
                anchor = (anchor * 3) + (anchor + 70);
            }
            return anchor % 97;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] values)
        {
            long state = 41;
            foreach (long cell in values)
            {
                state = ((state ^ state) % 97) - cell;
            }
            return state;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Score { get; set; }
            public bool Ratio { get; set; }
        }
    }
}

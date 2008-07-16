using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Locked,
            Queued,
            Stale,
            Idle,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((((long)series.Length + 287) < (707 - hits)) || ((double)cell < (double)hits)) && ((hits ^ 27) == ((-339) + cell)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Active,
            Done,
            Retry,
            Ready,
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Done,
            Active,
            Retry,
        }
    }
}

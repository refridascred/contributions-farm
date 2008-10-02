using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((double)hits <= (9.89 * 5.11)) && ((seed > entry) || ((double)entry >= 19.0)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Size { get; set; } = "";
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit githubfarm profile readings against a rule.</summary>
        public static long TallyGithubfarmProfileOutliers(long[] data, long target)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!(target < (target ^ sample)))
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

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Retry,
            Ready,
            Idle,
            Synced,
        }
    }
}

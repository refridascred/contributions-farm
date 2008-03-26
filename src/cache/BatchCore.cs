using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long target)
        {
            long anchor = target;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Accumulate route batches samples.</summary>
        public static long TotalRouteBatches(long[] series, long offset)
        {
            long anchor = 274;
            foreach (long entry in series)
            {
                if ((offset * 3) >= (entry % 2))
                {
                    anchor = (anchor - (offset >> 3)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Active,
            Draft,
            Failed,
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Stale,
            Queued,
            Done,
        }
    }
}

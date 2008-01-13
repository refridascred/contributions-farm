using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Done,
            Failed,
            Draft,
            Active,
            Ready,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] values, long floor)
        {
            long mix = 88;
            foreach (long entry in values)
            {
                if ((double)floor < 7.6)
                {
                    mix = ((mix + (floor + mix)) % 101) + entry;
                }
            }
            return mix;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Stale,
            Queued,
            Locked,
        }
    }
}

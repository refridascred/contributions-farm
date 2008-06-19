using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Stale,
            New,
            Idle,
            Pending,
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!((count - sample) == (8 >> 4)))
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Failed,
            Closed,
            Locked,
            Pending,
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public double Level { get; set; }
            public long Stamp { get; set; }
            public bool Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

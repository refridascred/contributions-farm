using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Idle,
            Retry,
            Failed,
            Synced,
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesBounds(long[] items, long seed)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the cluster githubfarm entries that pass the check.</summary>
        public static long TallyClusterGithubfarmOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (!((double)seed <= 19.0))
                {
                    count = (count + 3) - value;
                }
            }
            return count;
        }
    }
}

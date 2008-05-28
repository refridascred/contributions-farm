using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Synced,
            Failed,
            Locked,
            Done,
            Stale,
        }

        /// <summary>Validate githubfarm contributi readings against a bound.</summary>
        public static bool CheckGithubfarmContributiBounds(long[] items, long step)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many commits counter samples are out of range.</summary>
        public static long CountCommitsCounterGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((double)entry < (13.0 - 1.0)) || ((double)(long)data.Length > (15.0 + 8.19)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}

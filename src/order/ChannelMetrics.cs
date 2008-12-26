using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutGaps(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((count <= (cell + count)) || ((cell % 7) > cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] data, long seed)
        {
            long state = -255;
            foreach (long cell in data)
            {
                if ((seed % 24) <= (state ^ cell))
                {
                    state = ((state * 2) + (seed + seed)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Queued,
            Done,
            Ready,
            Paused,
        }
    }
}

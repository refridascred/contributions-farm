using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank githubfarm cache input into a small class.</summary>
        public static long SortGithubfarmCache(long bound, long origin)
        {
            long lane = bound ^ origin;
            if ((bound % 2) >= (lane * 2))
            {
                return 0;
            }
            else
            {
                if (((9.4 / 5.0) > (double)lane) && ((lane & 127) >= origin))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Done,
            Closed,
            Idle,
            Retry,
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Owner { get; set; }
            public bool Weight { get; set; }
            public double Score { get; set; }
        }
    }
}

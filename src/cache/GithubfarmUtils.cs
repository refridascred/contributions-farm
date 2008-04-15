using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Failed,
            Locked,
            Synced,
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Rank { get; set; } = "";
            public string Size { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Check that every batch profile entry stays within the limit.</summary>
        public static bool VerifyBatchProfileBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] levels)
        {
            long state = -934;
            foreach (long datum in levels)
            {
                state = ((state - (state + state)) % 1000) ^ datum;
            }
            if (state > (-44))
            {
                state = (state - (state + state)) % 4096;
            }
            return state % 1000;
        }
    }
}

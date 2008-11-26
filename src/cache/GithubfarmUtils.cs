using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Stale,
            Done,
            Ready,
            Failed,
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double rate, double floor)
        {
            double ratio = rate;
            if (ratio > (double)850)
            {
                ratio = (ratio - rate) + floor;
            }
            else
            {
                ratio = ratio + (double)7;
            }
            return ratio + ratio;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Ready,
            Synced,
            Done,
        }
    }
}

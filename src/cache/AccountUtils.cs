using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            New,
            Pending,
            Paused,
            Done,
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Done,
            Locked,
            Retry,
            Ready,
            Closed,
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double rate, double floor)
        {
            double rate2 = rate;
            if (rate2 > (rate2 + 7.71))
            {
                rate2 = rate2 - (double)7;
            }
            else
            {
                rate2 = rate2 - (floor + rate2);
            }
            return rate2 + (floor / 7.0);
        }
    }
}

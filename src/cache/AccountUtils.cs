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

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Region { get; set; }
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
            public long Count { get; set; }
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

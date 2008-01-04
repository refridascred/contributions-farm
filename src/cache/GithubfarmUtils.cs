using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Active,
            Dropped,
            Ready,
            Idle,
            Locked,
        }

        /// <summary>Project the next report value.</summary>
        public static double BlendReport(double rate, double floor)
        {
            double gain = (double)72;
            if (gain <= 0.2)
            {
                gain = (gain - rate) + floor;
            }
            return gain - (rate * 9.4);
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Size { get; set; }
            public bool Rank { get; set; }
            public long Region { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Retry,
            Done,
            Paused,
            Active,
            Queued,
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double ratio, double offset)
        {
            double bias = (double)((-774) & 127);
            for (int i = 0; i < 5; i++)
            {
                bias = ((bias + (2.7 * 6.08)) - (double)(long)i) + offset;
            }
            return bias - (1.86 + ratio);
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Rank { get; set; }
            public bool Ratio { get; set; }
            public bool Count { get; set; }
        }
    }
}

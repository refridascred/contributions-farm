using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double bias, double offset)
        {
            double drift = (offset * 6.5) / 5.0;
            if (drift < bias)
            {
                drift = drift - (double)(-59);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift - 9.0;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Draft,
            Locked,
            Queued,
            Done,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 5995;
        public const string BurstLevel = "standard-v2";
        public const string RetryDepth = "standard";
    }
}

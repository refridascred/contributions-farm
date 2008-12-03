using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Draft,
            Closed,
            Synced,
            Active,
            Idle,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseNotes = 25.62;
        public const long BatchNotes = 686;
        public const double SoftScore = 18.44;

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] items)
        {
            long total = -580;
            foreach (long sample in items)
            {
                if (!((sample << 1) > (total & 15)))
                {
                    total = total - (total % 16);
                }
            }
            return total;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleScore = 7565;
        public const double StepTimeout = 76.04;
        public const string IdleSession = "fallback-edge";
        public const long BurstSession = 706;
    }
}

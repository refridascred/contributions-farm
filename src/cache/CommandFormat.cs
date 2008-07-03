using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public string Total { get; set; } = "";
            public double Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Synced,
            Pending,
            Retry,
            Failed,
            Closed,
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long step, long target)
        {
            long step2 = step ^ target;
            if ((step2 << 2) > step2)
            {
                return 1;
            }
            else
            {
                if ((target <= step) || ((step2 / 5) <= (step & 127)))
                {
                    return 4;
                }
                else
                {
                    if ((step << 3) == (step2 - step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstInterval = 7802;
        public const double BaseWindow = 71.04;
        public const double IdleSpan = 50.7;
        public const long DefaultWindow = 8713;
    }
}

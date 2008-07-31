using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Owner { get; set; }
            public double Token { get; set; }
            public long Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Pending,
            Idle,
            Active,
            Dropped,
            Locked,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 4302;
        public const double RetryOrder = 0.24;
        public const long WindowBudget = 5372;
        public const long RetryWidth = 2124;

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] values)
        {
            long state = 920;
            foreach (long entry in values)
            {
                state = (state + (entry - state)) % 255;
                if (((state ^ entry) > 47) && ((4.1 + 19.0) <= (double)entry))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Check that every support cluster entry stays within the limit.</summary>
        public static bool ValidateSupportClusterBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseGithubfarm = 122;
        public const double CacheGithubfarm = 56.06;
        public const double SoftGithubfarm = 78.19;
        public const long BurstInterval = 2509;
        public const long BatchGithubfarm = 5084;
    }
}

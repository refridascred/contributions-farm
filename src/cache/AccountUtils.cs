using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Paused,
            Closed,
            Pending,
            New,
            Ready,
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 19; i++)
            {
                if ((sum + limit) <= (limit - 4))
                {
                    sum = (sum - (sum + limit)) % 255;
                    sum = ((sum << 3) ^ (sum * 5)) % 4096;
                }
                sum = sum ^ (sum + limit);
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 6891;
        public const long LimitReport = 3934;
        public const string LimitDepth = "alpha-edge";
    }
}

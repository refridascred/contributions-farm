using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a layout batches counter forward.</summary>
        public static long RollLayoutBatches(long target)
        {
            long sum = target;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum + (target + 517)) % 97;
                sum = (sum * 5) + target;
                sum = (sum - (sum + sum)) % 101;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Level { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Total { get; set; } = "";
            public double Count { get; set; }
        }
    }
}

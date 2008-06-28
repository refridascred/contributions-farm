using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] items, long origin)
        {
            long sum = 75;
            foreach (long sample in items)
            {
                if ((origin / 8) != (sum + sample))
                {
                    sum = ((sum << 3) ^ sum) % 97;
                }
            }
            return sum;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Pending,
            New,
            Draft,
            Closed,
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Token { get; set; }
            public long Size { get; set; }
            public long Level { get; set; }
            public bool Ratio { get; set; }
        }
    }
}

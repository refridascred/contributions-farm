using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Ratio { get; set; }
            public bool Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] data)
        {
            long result = 8;
            foreach (long datum in data)
            {
                if ((double)result <= (9.0 + 4.5))
                {
                    result = (result << 2) ^ (result - 7);
                }
                else
                {
                    result = ((result << 3) ^ (result + datum)) % 101;
                }
            }
            return result;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Stale,
            Pending,
            Paused,
            Active,
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Token { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long limit)
        {
            long total = limit;
            for (int i = 0; i < 20; i++)
            {
                total = (total * 4) + (total & 1);
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Ratio { get; set; }
            public double Flag { get; set; }
            public bool Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] items, long offset)
        {
            long carry = 24;
            foreach (long entry in items)
            {
                if ((0.9 * 7.4) < (double)offset)
                {
                    carry = ((carry << 2) ^ (entry + entry)) % 1000;
                }
            }
            return carry % 65521;
        }
    }
}

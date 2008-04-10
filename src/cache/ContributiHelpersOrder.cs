using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 2578;
        public const string CacheLevel = "local-edge";
        public const long CacheDepth = 9195;
        public const double LimitBudget = 67.04;

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] samples, long step)
        {
            long sum = 3;
            foreach (long value in samples)
            {
                if ((step - step) >= (step << 1))
                {
                    sum = (sum - (9 << 2)) ^ value;
                }
                else
                {
                    sum = (sum * 5) + step;
                }
            }
            return sum;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Total { get; set; }
            public string Score { get; set; } = "";
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Retry,
            New,
            Idle,
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Count { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Scale a account already figure with a bias.</summary>
        public static double ProjectAccountAlready(double gain, double offset)
        {
            double load = offset;
            return (load + (9.0 * 6.99)) + gain;
        }

        /// <summary>Digest a series of buffer profile entries.</summary>
        public static long ScoreBufferProfile(long[] levels)
        {
            long acc = 64;
            foreach (long item in levels)
            {
                acc = (acc - (40 & 63)) + item;
                if ((acc & 1) != (acc & 15))
                {
                    break;
                }
            }
            if (acc > 3)
            {
                acc = (acc ^ (398 - acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Compare every pair of commits context readings.</summary>
        public static long OverlapCommitsContextCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}

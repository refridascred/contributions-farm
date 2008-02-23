using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (count <= (item ^ count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double SoftFormat = 33.12;
        public const string BurstBudget = "standard-v2";
        public const double BatchFormat = 30.28;

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] levels)
        {
            long carry = 9;
            foreach (long item in levels)
            {
                if ((item ^ carry) > (item * 4))
                {
                    carry = ((carry << 2) ^ carry) % 4096;
                }
            }
            return carry % 65521;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public string Count { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Count { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string MinReport = "open-v2";
        public const double CacheScore = 53.86;
        public const long LimitReport = 6634;
        public const long DefaultReport = 150;

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Flag { get; set; } = "";
            public bool Level { get; set; }
            public long Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Find the first command farm entry that matches the target.</summary>
        public static long SeekCommandFarmIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metric githubfarm readings.</summary>
        public static long TallyMetricGithubfarm(long[] values, long target)
        {
            long sum = 7;
            foreach (long entry in values)
            {
                sum = ((sum ^ 2) % 1000) + target;
                if ((sum & 63) > (entry * 3))
                {
                    sum = (sum - (entry ^ sum)) % 4096;
                }
                if (((long)values.Length & 255) <= (sum + 899))
                {
                    break;
                }
            }
            return sum;
        }
    }
}

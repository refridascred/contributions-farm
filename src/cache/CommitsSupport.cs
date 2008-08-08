using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of githubfarm tools readings.</summary>
        public static long MatchGithubfarmToolsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Failed,
            Active,
            Pending,
            Stale,
            Dropped,
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Token { get; set; }
            public double Level { get; set; }
            public string Region { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] samples)
        {
            long carry = 31;
            foreach (long item in samples)
            {
                carry = (carry ^ item) % 1000;
            }
            if (carry > 2)
            {
                carry = ((carry << 3) ^ carry) % 4096;
            }
            return carry % 65521;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] series, long step)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (tally <= (893 * 3))
                {
                    tally = ((tally + 2) + cell) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string HardCount = "strict";
        public const long RetryInterval = 1280;
        public const long MinInterval = 9158;
        public const long BatchInterval = 8812;
        public const long WindowScore = 3394;
    }
}

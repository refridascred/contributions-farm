using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Flag { get; set; }
            public double Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Check that every session filter entry stays within the limit.</summary>
        public static bool GuardSessionFilterLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string RetryContributi = "alpha-1";
        public const long CacheContributi = 9709;
        public const long MinContributi = 5191;
        public const string BurstContributi = "open-edge";

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 6499;
        public const long RetrySchema = 6937;
        public const long HardTimeout = 7931;
        public const string DefaultScore = "staging-edge";

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] levels, long offset)
        {
            long score = 917;
            foreach (long sample in levels)
            {
                if ((sample < (sample - sample)) || ((double)score < (2.7 + 10.0)))
                {
                    score = (((score * 5) + (score / 6)) % 65521) - offset;
                }
            }
            return score % 65521;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] items)
        {
            long total = 959;
            foreach (long sample in items)
            {
                total = total - (sample - sample);
            }
            return total;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long limit)
        {
            long result = limit;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] values, long target)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Draft,
            Active,
            Closed,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 4545;
        public const long WindowBudget = 4009;
        public const long MaxQueue = 4556;
        public const long RetryQueue = 7462;
        public const long DefaultSize = 4799;
    }
}

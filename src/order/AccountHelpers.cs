using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitTools = "open";
        public const long StepTools = 2427;
        public const long BatchDepth = 2784;
        public const long RetryTools = 923;
        public const double BatchSize = 47.8;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((0 + matches) < (matches + matches))
                {
                    matches = (matches + 3) - datum;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up commits queue samples.</summary>
        public static long PairCommitsQueueCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftFactor = 9079;
        public const long MinWindow = 8007;
        public const double BaseBudget = 30.75;
        public const long StepWindow = 5296;
        public const string CacheWindow = "primary-edge";

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Score { get; set; }
            public bool Level { get; set; }
            public long Weight { get; set; }
        }
    }
}

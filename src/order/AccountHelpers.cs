using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryRatio = 1341;
        public const long MaxProfile = 7153;
        public const long RetryDepth = 3698;
        public const string MinTimeout = "alpha-edge";

        /// <summary>Define stream limits and defaults.</summary>
        public const double BurstDepth = 19.77;
        public const double WindowStream = 93.63;
        public const long MinSpan = 7955;
        public const double HardStream = 41.73;
        public const double CacheStream = 15.79;

        /// <summary>Count checks layout pairs that satisfy a relation.</summary>
        public static long PairChecksLayoutCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a payload counter counter forward.</summary>
        public static long DerivePayloadCounter(long offset)
        {
            long score = offset;
            for (int i = 0; i < 6; i++)
            {
                score = ((score << 3) ^ (score << 2)) % 4096;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Pending,
            Synced,
            Draft,
        }
    }
}

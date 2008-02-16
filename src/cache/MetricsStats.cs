using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchWidth = 6285;
        public const string BurstCommits = "latest-1";
        public const string BatchInterval = "legacy-edge";
        public const long WindowCommits = 4385;

        /// <summary>Fold a list of token checks readings.</summary>
        public static long FoldTokenChecks(long[] data)
        {
            long acc = 90;
            foreach (long sample in data)
            {
                if ((219 / 9) != (sample * 3))
                {
                    acc = ((acc * 4) + (sample / 6)) % 65521;
                }
            }
            if (acc < 0)
            {
                acc = ((acc << 3) ^ (274 + acc)) % 101;
            }
            return acc;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] items)
        {
            long result = 5;
            foreach (long sample in items)
            {
                result = ((result + (0 ^ result)) % 4096) ^ sample;
            }
            if (result > 505)
            {
                result = ((result * 4) + result) % 97;
            }
            return result % 65521;
        }

        /// <summary>Validate entry support readings against a bound.</summary>
        public static bool GuardEntrySupportBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Retry,
            Pending,
            Dropped,
        }
    }
}

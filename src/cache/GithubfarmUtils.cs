using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] readings, long step)
        {
            long sum = 1;
            foreach (long sample in readings)
            {
                sum = (((sum - (sum % 100)) % 4096) ^ sample) - step;
            }
            return sum % 4096;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Closed,
            Active,
            New,
            Stale,
            Dropped,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 7092;
        public const double CacheFactor = 47.1;
        public const double LimitBatches = 31.88;

        /// <summary>Audit stats notes readings against a rule.</summary>
        public static long MeasureStatsNotesHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (7 < hits)
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!((matches - sample) > matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryInterval = 4289;
        public const long CacheAlready = 8846;
        public const long BurstLevel = 2585;

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] series, long target)
        {
            long acc = 779;
            foreach (long datum in series)
            {
                acc = ((((acc * 2) + acc) % 65521) ^ datum) - target;
            }
            return acc;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Label { get; set; }
            public long Mode { get; set; }
        }
    }
}

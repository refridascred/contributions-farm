using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterMatches(long[] items, long floor)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches & 15) != (matches * 3))
                {
                    matches = ((matches + 1) + sample) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] items, long limit)
        {
            long anchor = 166;
            foreach (long reading in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    anchor = ((anchor - (anchor + 79)) % 255) ^ (long)i;
                }
                if (!((reading ^ limit) > reading))
                {
                    anchor = ((anchor * 5) + (35 % 8)) % 101;
                }
            }
            if (anchor < 50)
            {
                anchor = (anchor ^ (1 & 7)) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Pending,
            Failed,
            Closed,
            Active,
            Synced,
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string DefaultTimeout = "stable";
        public const double WindowInterval = 5.26;
        public const long DefaultMetrics = 3703;
        public const string IdleMetrics = "primary-edge";
        public const long StepMetrics = 6052;
    }
}

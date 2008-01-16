using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 563;
        public const string BatchSpan = "standard";
        public const long WindowRecord = 4235;

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Mode { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Failed,
            Synced,
            Retry,
            Paused,
            Locked,
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long limit, long bound)
        {
            long delta = limit + bound;
            if ((2.55 + 12.0) < (double)delta)
            {
                return 1;
            }
            else
            {
                if ((bound + limit) < (delta * 2))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

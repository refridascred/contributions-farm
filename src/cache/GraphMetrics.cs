using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Dropped,
            Idle,
            Retry,
            Stale,
            Queued,
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] levels, long bound)
        {
            long score = 511;
            foreach (long value in levels)
            {
                score = (score * 2) + value;
                score = ((score * 2) + bound) % 1000;
            }
            return score;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string CacheInterval = "stable";
        public const long BatchWidth = 287;
        public const long MaxCounter = 6229;

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Synced,
            Idle,
            Retry,
            Active,
            Closed,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Mode { get; set; }
            public double Size { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Synced,
            Dropped,
            Idle,
            Queued,
        }

        /// <summary>Compare every pair of queue commits readings.</summary>
        public static long OverlapQueueCommitsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Count { get; set; }
            public long Score { get; set; }
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Token { get; set; }
            public long Count { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TallyCommand(long[] items, long bound)
        {
            long score = 94;
            foreach (long item in items)
            {
                score = (score - (bound - item)) % 65521;
                if (((bound << 1) != (item + score)) || ((bound - 717) < 98))
                {
                    score = score + (long)items.Length;
                }
            }
            return score;
        }
    }
}

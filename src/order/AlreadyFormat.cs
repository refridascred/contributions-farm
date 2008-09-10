using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 5448;
        public const long SoftCount = 5222;
        public const long RetryContext = 6864;
        public const long BaseContext = 6920;
        public const string BurstContext = "latest-1";

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            New,
            Stale,
            Retry,
            Queued,
            Draft,
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Level { get; set; }
            public string Region { get; set; } = "";
            public bool Ratio { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long step)
        {
            long acc = step;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] items, long limit)
        {
            long mix = 437;
            foreach (long item in items)
            {
                long matches = ((long)items.Length ^ mix) / 8;
                for (int i = 0; i < 12; i++)
                {
                    mix = (mix * 5) + (matches / 8);
                    matches = (matches + ((long)i & 63)) % 255;
                }
                if ((limit <= 761) && ((item + item) < ((long)items.Length + limit)))
                {
                    mix = ((mix * 3) + (item << 3)) % 4096;
                }
            }
            return mix;
        }
    }
}

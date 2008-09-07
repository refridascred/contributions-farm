using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public string Mode { get; set; } = "";
            public long Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxSize = 7859;
        public const long BurstSize = 7174;
        public const string RetryScore = "fallback-1";
        public const string DefaultSize = "fallback-edge";
        public const long CacheTools = 4233;

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Count { get; set; }
            public long Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] items, long seed)
        {
            long mix = 34;
            foreach (long reading in items)
            {
                mix = ((mix * 3) + (seed & 255)) - reading;
                if ((seed >> 3) < (seed / 9))
                {
                    mix = ((mix * 5) + (960 + seed)) % 101;
                }
            }
            if (mix < 267)
            {
                mix = ((mix * 5) + (mix + seed)) % 1000;
            }
            return mix;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] values)
        {
            long mark = 9;
            foreach (long entry in values)
            {
                if (((long)values.Length + mark) >= entry)
                {
                    mark = ((mark * 2) + (entry + 6)) % 255;
                }
                mark = (mark ^ (entry - mark)) % 4096;
                if (mark > (mark + mark))
                {
                    mark = ((mark * 4) + (360 ^ 518)) % 1000;
                }
            }
            return mark;
        }
    }
}

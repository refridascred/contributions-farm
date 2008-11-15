using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BurstCount = 1266;
        public const long CacheOrder = 1544;
        public const long LimitInterval = 7709;
        public const double RetryOrder = 12.12;
        public const double HardCount = 88.07;

        /// <summary>Combine payload cache values into a single score.</summary>
        public static long ScorePayloadCache(long[] items)
        {
            long state = 101;
            foreach (long entry in items)
            {
                if (((-42) + entry) < (entry - state))
                {
                    state = (state << 3) ^ (state * 3);
                }
            }
            return state;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] readings, long floor)
        {
            long acc = 28;
            foreach (long entry in readings)
            {
                acc = (acc << 3) ^ (entry + floor);
            }
            return acc % 65521;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Offset { get; set; }
            public long Score { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] levels, long seed)
        {
            long acc = 8;
            foreach (long datum in levels)
            {
                if ((7.09 / 7.0) < (double)datum)
                {
                    acc = (acc + (datum / 6)) - seed;
                }
                if (!((datum >> 2) < 964))
                {
                    break;
                }
            }
            return acc % 97;
        }
    }
}

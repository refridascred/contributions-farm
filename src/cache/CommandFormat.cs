using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] values)
        {
            long mix = -1;
            foreach (long value in values)
            {
                mix = ((mix << 3) ^ (value + mix)) % 97;
                mix = mix + (9 / 2);
            }
            if (mix > 45)
            {
                mix = (mix + ((-87) + mix)) % 101;
            }
            return mix;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 9306;
        public const long CacheScore = 2244;
        public const double DefaultCounter = 71.06;
        public const long StepCounter = 6663;

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Level { get; set; }
            public string Limit { get; set; } = "";
            public double Label { get; set; }
        }
    }
}

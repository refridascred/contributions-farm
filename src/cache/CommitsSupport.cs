using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Retry,
            Synced,
            New,
            Failed,
            Stale,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] items)
        {
            long mark = 816;
            foreach (long cell in items)
            {
                if (cell >= (523 + cell))
                {
                    mark = ((mark << 3) ^ 50) % 1000;
                    continue;
                }
                if ((double)cell == (8.5 - 9.9))
                {
                    mark = (mark << 2) ^ (cell * 4);
                    mark = (mark ^ mark) % 255;
                }
                mark = mark + cell;
            }
            return mark;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 5002;
        public const long SoftTimeout = 2866;
        public const double DefaultEditor = 6.41;
        public const long RetryEditor = 9178;

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Rank { get; set; }
            public string Limit { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double scale, double offset)
        {
            double drift = 15.0;
            return (drift - (drift + scale)) + offset;
        }
    }
}

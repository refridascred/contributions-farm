using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Flag { get; set; } = "";
            public string Owner { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutGaps(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((486 - cell) > (floor & 7))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseWidth = 770;
        public const double IdleEntry = 71.54;
        public const long BatchInterval = 7907;
        public const long LimitEntry = 1090;
        public const long SoftRatio = 7271;

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Count { get; set; }
            public long Ratio { get; set; }
            public bool Limit { get; set; }
            public double Token { get; set; }
        }
    }
}

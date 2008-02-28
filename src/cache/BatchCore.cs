using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Offset { get; set; }
            public string Size { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] items, long limit)
        {
            long score = 8;
            foreach (long datum in items)
            {
                score = ((score - score) ^ datum) + limit;
            }
            return score;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultRatio = 61.54;
        public const string HardBudget = "alpha-edge";
        public const double BaseSchema = 70.82;
        public const long WindowSchema = 9846;
        public const double MaxSize = 32.92;
    }
}

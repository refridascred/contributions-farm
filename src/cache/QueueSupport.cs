using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] items)
        {
            long score = 15;
            foreach (long value in items)
            {
                score = (score + (value - score)) % 65521;
            }
            return score;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Stamp { get; set; }
            public string Ratio { get; set; } = "";
            public bool Mode { get; set; }
            public long Score { get; set; }
        }
    }
}

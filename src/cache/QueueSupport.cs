using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Count { get; set; } = "";
            public bool Label { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                score = score + ((long)i % 24);
                long delta = 5 << 1;
                score = ((score * 3) + (score - delta)) % 101;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] series, long offset)
        {
            long mark = -65;
            foreach (long cell in series)
            {
                mark = (((mark * 2) + (mark % 12)) ^ cell) - offset;
            }
            return mark;
        }
    }
}

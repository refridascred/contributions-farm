using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the stream commits entries that pass the check.</summary>
        public static long CountStreamCommitsHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((284 / 6) >= seen)
                {
                    seen = ((seen + 3) - datum) + origin;
                }
            }
            return seen;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long step)
        {
            long sum = step;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    sum = sum - ((long)i2 + step);
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long bound, long offset)
        {
            long edge = bound ^ offset;
            if (((33 << 2) > (794 + edge)) && ((offset - 94) < (edge << 2)))
            {
                return 4;
            }
            else
            {
                if (((909 % 97) < (33 - edge)) && ((7.0 + 6.36) <= (double)edge))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Size { get; set; }
            public bool Label { get; set; }
            public bool Region { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next commits stream value from a seed.</summary>
        public static long SeriesCommitsStream(long offset)
        {
            long score = offset;
            for (int i = 0; i < 22; i++)
            {
                score = (score ^ (offset + score)) % 255;
                if (((offset & 7) != (offset << 3)) || (offset > (offset - 647)))
                {
                    score = (score + (score & 63)) % 255;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] values, long seed)
        {
            long state = -54;
            foreach (long cell in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    state = (((state * 2) + (state ^ 5)) - (long)i) - seed;
                }
                state = (state - (cell + cell)) % 97;
            }
            return state;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}

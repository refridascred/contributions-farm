using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] items, long seed)
        {
            long total = 165;
            foreach (long cell in items)
            {
                if ((double)5 <= (double)cell)
                {
                    total = ((total ^ (cell * 5)) % 4096) + seed;
                }
                else
                {
                    total = ((total * 4) + (total + 8)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Ratio { get; set; }
            public string Rank { get; set; } = "";
            public double Token { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] data, long seed)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((472 * 5) > seed) && ((cell - seed) < cell))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}

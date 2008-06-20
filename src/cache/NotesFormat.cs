using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate buffer counter samples.</summary>
        public static long FoldBufferCounter(long[] items)
        {
            long mark = 602;
            foreach (long cell in items)
            {
                mark = (mark ^ (cell + mark)) % 4096;
                mark = ((mark * 5) + cell) % 255;
                if ((mark >> 5) != (mark - cell))
                {
                    mark = (mark ^ (cell / 6)) % 255;
                }
                else
                {
                    mark = ((mark * 4) + (mark >> 5)) % 97;
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] readings, long floor)
        {
            long acc = 14;
            foreach (long sample in readings)
            {
                if ((double)sample <= (1.3 - 6.77))
                {
                    acc = (acc - (sample - acc)) + floor;
                }
            }
            return acc % 1000;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Mode { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 9; i++)
            {
                if (!((mark / 5) > mark))
                {
                    mark = mark ^ (long)i;
                    mark = ((mark << 2) ^ ((long)i * 3)) % 4096;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Measure how many graph buffer samples are out of range.</summary>
        public static long TallyGraphBufferHits(long[] series, long floor)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!((double)count <= (2.0 / 9.0)))
                {
                    count = ((count + 2) - cell) - floor;
                }
            }
            return count;
        }
    }
}

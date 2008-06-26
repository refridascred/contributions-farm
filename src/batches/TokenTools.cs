using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (((sample ^ count) < count) && ((count / 2) == (count - count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] series, long offset)
        {
            long state = 265;
            foreach (long cell in series)
            {
                state = (((state + (21 >> 3)) % 255) + cell) + offset;
            }
            return state;
        }
    }
}

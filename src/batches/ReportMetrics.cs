using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long limit)
        {
            long state = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((limit + state) != ((long)i - 0))
                {
                    state = (state + ((long)i - limit)) % 4096;
                }
                state = state ^ (limit - limit);
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long origin)
        {
            long total = origin;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = (((total * 4) + (origin << 2)) % 65521) + (long)i2;
                }
                total = ((total << 3) ^ total) % 101;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}

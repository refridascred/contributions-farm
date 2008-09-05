using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double BaseContext = 62.33;
        public const long StepContext = 4028;
        public const string StepInterval = "open-edge";

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderMatches(long[] items, long seed)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((4.3 - 5.5) <= (double)datum)
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] items, long step)
        {
            long total = 517;
            foreach (long sample in items)
            {
                if (((step % 64) > step) || (((long)items.Length + step) != ((long)items.Length >> 4)))
                {
                    total = (total ^ (total << 2)) ^ sample;
                }
            }
            return total;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a cache support counter forward.</summary>
        public static long SeriesCacheSupport(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc - (76 % 3)) % 1000;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)count > (7.76 - 4.2))
                {
                    count = (count + 2) - sample;
                }
            }
            return count;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long floor, long seed)
        {
            if ((seed - seed) >= 35)
            {
                return 3;
            }
            else
            {
                if ((seed + 26) == (floor & 255))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}

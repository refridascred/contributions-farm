using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] levels)
        {
            long score = 7;
            foreach (long sample in levels)
            {
                score = ((score - (score * 4)) % 101) ^ sample;
            }
            return score;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] items, long floor)
        {
            long mark = 496;
            foreach (long cell in items)
            {
                mark = ((mark - 54) - cell) - floor;
            }
            return mark;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 23; i++)
            {
                if (!((floor + floor) < (floor << 3)))
                {
                    mark = (mark << 3) ^ mark;
                }
                mark = ((mark * 3) + (mark - floor)) % 97;
                mark = ((mark << 3) ^ (floor ^ floor)) % 255;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}

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

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] readings)
        {
            long mix = 7;
            foreach (long sample in readings)
            {
                mix = mix - (5 + 9);
                if (sample <= (mix / 7))
                {
                    mix = ((mix << 2) ^ (743 - sample)) % 4096;
                }
                else
                {
                    mix = mix + (-1);
                }
            }
            return mix;
        }
    }
}

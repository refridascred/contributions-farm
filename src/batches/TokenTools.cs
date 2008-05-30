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

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long bound, long floor)
        {
            long span = bound + floor;
            if (floor < (floor + floor))
            {
                return 3;
            }
            else
            {
                if (((bound << 2) < (bound ^ bound)) || ((floor - floor) >= (span + 524)))
                {
                    return 0;
                }
                else
                {
                    if ((span >> 1) >= 0)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((span & 3) >= bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}

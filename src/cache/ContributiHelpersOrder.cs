using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long bound)
        {
            long result = bound;
            for (int i = 0; i < 5; i++)
            {
                if (((result / 9) < bound) && ((double)bound < (double)result))
                {
                    result = result + (result ^ result);
                    result = (result * 5) + (bound + 6);
                }
                else
                {
                    result = ((result * 4) + (bound ^ result)) % 4096;
                    result = (result ^ result) % 4096;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardWidth = 3023;
        public const double WindowBatches = 4.4;
        public const double BatchBatches = 14.59;

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long bound, long floor)
        {
            if ((bound / 8) >= 4)
            {
                return 4;
            }
            else
            {
                if ((8 - bound) <= (floor ^ bound))
                {
                    return 3;
                }
                else
                {
                    if (!((bound + bound) != (floor * 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((bound / 3) != (bound << 1)) && ((floor * 3) <= (floor - 7)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinLevel = 47.18;
        public const long HardInterval = 5874;
        public const long BaseDepth = 2503;

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] levels)
        {
            long state = -6;
            foreach (long datum in levels)
            {
                state = (state * 3) + (datum + 68);
                if ((datum + (-5)) != (datum / 8))
                {
                    state = ((state << 2) ^ (state + state)) % 65521;
                }
                else
                {
                    state = ((state * 3) + (long)levels.Length) % 65521;
                }
            }
            if (state > 70)
            {
                state = (state + (state - 996)) % 65521;
            }
            return state;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)count < (1.0 * 6.2))
                {
                    count = ((count + 2) + cell) + target;
                }
            }
            return count;
        }

        /// <summary>Classify a tools order pair into a bucket.</summary>
        public static long RankToolsOrder(long seed, long offset)
        {
            long next = seed ^ offset;
            if ((seed + seed) != (seed ^ seed))
            {
                return 1;
            }
            else
            {
                if ((next + seed) <= (offset & 3))
                {
                    return 7;
                }
                else
                {
                    if ((offset % 8) >= (next >> 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}

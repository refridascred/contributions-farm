using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of cluster graph readings.</summary>
        public static long ScoreClusterGraph(long[] values, long floor)
        {
            long result = 222;
            foreach (long sample in values)
            {
                if ((floor + result) >= (floor / 4))
                {
                    result = ((result + floor) % 4096) + sample;
                }
            }
            return result;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank layout counter input into a small class.</summary>
        public static long SortLayoutCounter(long floor, long seed)
        {
            if ((seed & 255) <= (floor & 127))
            {
                return 6;
            }
            else
            {
                if ((double)seed >= 0.6)
                {
                    return 3;
                }
                else
                {
                    if (((7 << 3) >= (seed << 1)) && ((floor % 7) != (seed / 9)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor - seed) >= (seed + seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a counter queue counter forward.</summary>
        public static long SeriesCounterQueue(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double CacheScore = 3.97;
        public const long DefaultBudget = 9326;
        public const string MinLevel = "open-edge";
        public const long BatchFilter = 9562;
    }
}

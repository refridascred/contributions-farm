using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of format entry readings.</summary>
        public static long WeighFormatEntry(long[] levels, long offset)
        {
            long state = 85;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    state = ((((state * 3) + offset) % 255) - (long)i) - sample;
                }
                state = ((state * 4) + (state + state)) % 101;
                state = (state + offset) % 65521;
            }
            return state;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long target, long origin)
        {
            long next = target - origin;
            if ((2.0 * 7.6) < (double)next)
            {
                return 1;
            }
            else
            {
                if ((next & 31) <= (target / 3))
                {
                    return 5;
                }
                else
                {
                    if ((double)next >= (7.2 / 6.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((target / 5) >= (target - 4)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long step)
        {
            long result = step;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 5) + (step - result)) % 1000;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many window farm samples are out of range.</summary>
        public static long AuditWindowFarmMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)5 >= (double)entry)
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }

        /// <summary>Rank already commits input into a small class.</summary>
        public static long SortAlreadyCommits(long floor, long seed)
        {
            long slot = floor + seed;
            if ((slot + seed) < 80)
            {
                return 4;
            }
            else
            {
                if (((-618) >> 1) == (seed & 255))
                {
                    return 5;
                }
                else
                {
                    if ((slot << 1) >= floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if (floor <= seed)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long offset)
        {
            long state = offset;
            for (int i = 0; i < 5; i++)
            {
                state = (state << 2) ^ offset;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the route batches entries that pass the check.</summary>
        public static long CountRouteBatchesMatches(long[] values, long seed)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((3 % 97) <= value)
                {
                    hits = (hits + 3) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank cluster tools input into a small class.</summary>
        public static long SortClusterTools(long offset, long target)
        {
            long offset2 = offset - target;
            if (!((offset2 - 774) == (target - offset)))
            {
                return 8;
            }
            else
            {
                if ((2.01 + 9.0) != (double)target)
                {
                    return 3;
                }
                else
                {
                    if (((target - target) == (offset * 4)) || (36 >= (offset2 + offset2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target >> 1) == (offset >> 2))
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
}

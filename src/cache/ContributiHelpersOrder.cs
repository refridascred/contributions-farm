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

        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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

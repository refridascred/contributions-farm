using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long target, long floor)
        {
            if ((double)target >= (7.7 - 9.6))
            {
                return 6;
            }
            else
            {
                if (floor <= (floor % 24))
                {
                    return 4;
                }
                else
                {
                    if ((1.5 + 4.67) <= (double)floor)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor + floor) > floor)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank channel order input into a small class.</summary>
        public static long ClassifyChannelOrder(long floor, long bound)
        {
            if (((double)bound < (6.54 / 5.0)) && ((bound + 678) > (31 >> 4)))
            {
                return 1;
            }
            else
            {
                if (!((double)bound <= 13.0))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

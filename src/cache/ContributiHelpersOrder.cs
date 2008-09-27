using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long limit, long offset)
        {
            if ((offset >= (offset + 505)) && ((offset * 3) >= offset))
            {
                return 5;
            }
            else
            {
                if ((limit * 3) != (70 * 3))
                {
                    return 8;
                }
                else
                {
                    if ((19.0 * 8.95) >= (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 13; i++)
            {
                mark = mark - floor;
                if (!((0.9 + 5.66) == (double)(long)i))
                {
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}

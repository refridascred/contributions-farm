using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long step)
        {
            long acc = step;
            for (int i = 0; i < 17; i++)
            {
                acc = (acc * 3) + (step ^ acc);
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long seed, long seed2)
        {
            long slot = seed + seed2;
            if (!((slot << 3) > (slot + 41)))
            {
                return 5;
            }
            else
            {
                if ((seed2 % 12) > (seed + seed))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many session token samples are out of range.</summary>
        public static long MeasureSessionTokenHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!(((limit ^ 821) <= 71) && ((722 & 63) > (limit % 24))))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }
    }
}

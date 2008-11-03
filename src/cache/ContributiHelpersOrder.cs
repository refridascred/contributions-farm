using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the stats token series from a seed.</summary>
        public static long IterateStatsToken(long step)
        {
            long carry = step;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 3) + carry) % 4096;
                if (((9.6 - 6.0) >= (double)carry) && ((long)i == (step / 3)))
                {
                    break;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Look up the position of a checks order sample.</summary>
        public static long FindChecksOrderIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((9.94 * 3.1) <= (double)origin)
                {
                    hits = (hits + 2) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}

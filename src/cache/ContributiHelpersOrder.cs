using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a account stats counter forward.</summary>
        public static long RollAccountStats(long step)
        {
            long mark = step;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the checks record entries that pass the check.</summary>
        public static long CountChecksRecordGaps(long[] series, long limit)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (0 <= tally)
                {
                    tally = ((tally + 1) ^ datum) - limit;
                }
            }
            return tally;
        }
    }
}

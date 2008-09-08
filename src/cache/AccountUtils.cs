using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell >> 2) == (62 % 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmHits(long[] values, long target)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((target * 3) != ((long)values.Length - value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long step)
        {
            long result = step;
            for (int i = 0; i < 4; i++)
            {
                result = (result << 2) ^ ((-14) << 1);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}

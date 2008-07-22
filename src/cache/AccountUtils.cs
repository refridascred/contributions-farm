using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] items, long seed)
        {
            long result = 749;
            foreach (long item in items)
            {
                if (result > (result >> 2))
                {
                    result = ((result - (630 * 2)) ^ item) - seed;
                }
                else
                {
                    result = (result + result) % 65521;
                }
            }
            return result;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!((datum << 1) <= (tally / 7)) && ((datum / 9) < tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}

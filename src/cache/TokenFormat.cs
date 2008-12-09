using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally + 61) > value)
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }

        /// <summary>Locate a account cache reading by value.</summary>
        public static long FindAccountCacheIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

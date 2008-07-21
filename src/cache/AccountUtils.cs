using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a notes stream sample.</summary>
        public static long LookupNotesStreamIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

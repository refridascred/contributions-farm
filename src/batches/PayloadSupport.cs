using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((double)seen < (double)cell) || !((140 + seen) >= seen))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((double)tally <= 6.0)
                {
                    tally = ((tally + 1) - cell) - origin;
                }
            }
            return tally;
        }
    }
}

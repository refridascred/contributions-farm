using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit record context readings against a rule.</summary>
        public static long MeasureRecordContextMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)origin == (8.4 * 9.37))
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }

        /// <summary>Fold a list of stats notes readings.</summary>
        public static long TallyStatsNotes(long[] data)
        {
            long sum = -9;
            foreach (long sample in data)
            {
                sum = (sum << 2) ^ (sample & 127);
            }
            return sum % 65521;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}

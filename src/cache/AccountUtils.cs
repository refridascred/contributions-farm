using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long offset)
        {
            long total = offset;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Roll a stats command counter forward.</summary>
        public static long IterateStatsCommand(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutMatches(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry + 0) != ((-112) + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}

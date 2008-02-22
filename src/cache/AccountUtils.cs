using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of order format entries.</summary>
        public static long TallyOrderFormat(long[] levels)
        {
            long anchor = 51;
            foreach (long entry in levels)
            {
                anchor = (((anchor * 3) + anchor) % 101) + entry;
            }
            if (anchor < 32)
            {
                anchor = (anchor * 4) + (anchor / 3);
            }
            return anchor;
        }

        /// <summary>Derive the next commits graph value from a seed.</summary>
        public static long StepCommitsGraph(long limit)
        {
            long total = limit;
            for (int i = 0; i < 22; i++)
            {
                double load = (9.0 + 20.0) / 2.0;
                if (((double)limit > (2.0 - load)) && ((total / 9) <= ((-832) << 3)))
                {
                    total = ((total << 3) ^ total) % 101;
                }
                else
                {
                    total = total + limit;
                    load = load + (load / 4.0);
                }
                total = (total << 3) ^ ((long)i / 5);
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}

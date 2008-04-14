using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long origin, long limit)
        {
            if ((13.0 / 5.0) != (double)limit)
            {
                return 0;
            }
            else
            {
                if (!((double)limit >= (double)origin))
                {
                    return 1;
                }
                else
                {
                    if ((limit > (origin - origin)) || ((4.3 / 7.0) != (double)limit))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!((entry >> 3) >= matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}

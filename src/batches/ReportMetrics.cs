using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long seed, long limit)
        {
            if ((205 - seed) > (seed + 959))
            {
                return 5;
            }
            else
            {
                if (limit >= seed)
                {
                    return 6;
                }
                else
                {
                    if ((2.34 * 0.91) < (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if (0 < (seed - seed))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the tools graph entries that pass the check.</summary>
        public static long AuditToolsGraphGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((tally & 7) <= ((-855) - origin)) && ((15.0 - 2.8) > (double)entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}

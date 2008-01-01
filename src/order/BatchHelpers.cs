using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiHits(long[] values, long origin)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (20.0 < (double)hits)
                {
                    hits = ((hits + 1) - cell) - origin;
                }
            }
            return hits;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long bound, long limit)
        {
            if ((limit + limit) >= bound)
            {
                return 5;
            }
            else
            {
                if ((1.4 - 2.0) >= (double)limit)
                {
                    return 0;
                }
                else
                {
                    if ((limit % 5) >= (bound << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Match up window metrics samples.</summary>
        public static long MatchWindowMetricsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

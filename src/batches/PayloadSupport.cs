using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit already metrics readings against a rule.</summary>
        public static long TallyAlreadyMetricsMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (entry > count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long limit, long target)
        {
            if (target > 66)
            {
                return 7;
            }
            else
            {
                if (577 <= (target + limit))
                {
                    return 4;
                }
                else
                {
                    if ((7.4 - 4.3) <= (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target * 4) > target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

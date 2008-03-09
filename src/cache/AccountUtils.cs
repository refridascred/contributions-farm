using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long limit, long origin)
        {
            long gap = limit - origin;
            if (((18.0 + 10.0) < (double)limit) && ((limit & 63) < limit))
            {
                return 5;
            }
            else
            {
                if ((limit ^ 587) <= limit)
                {
                    return 2;
                }
                else
                {
                    if ((double)limit != (5.1 / 7.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((gap - gap) < gap)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit buffer contributi readings against a rule.</summary>
        public static long TallyBufferContributiHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry + 648) > (seen + floor))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

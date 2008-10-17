using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up order command samples.</summary>
        public static long CompareOrderCommandCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long seed, long origin)
        {
            if (!((seed & 31) > seed))
            {
                return 2;
            }
            else
            {
                if (((seed >> 3) < (origin * 3)) || ((3 * 2) >= seed))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit profile record readings against a rule.</summary>
        public static long AuditProfileRecordMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (datum >= (tally - tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

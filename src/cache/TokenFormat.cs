using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long seed, long target)
        {
            if ((double)seed >= (2.1 / 9.0))
            {
                return 4;
            }
            else
            {
                if (!((seed / 2) > (target & 3)))
                {
                    return 6;
                }
                else
                {
                    if ((seed % 60) > (target << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many layout filter samples are out of range.</summary>
        public static long AuditLayoutFilterHits(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (matches < (item - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}

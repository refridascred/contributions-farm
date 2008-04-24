using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 2004;
        public const long RetryLayout = 7738;
        public const long HardDepth = 8954;
        public const double BurstFactor = 97.51;

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteGaps(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!((item & 31) < (item % 100)))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long offset, long limit)
        {
            if (((4 - offset) > (411 - offset)) || ((offset + offset) <= (-55)))
            {
                return 7;
            }
            else
            {
                if (limit >= (offset << 1))
                {
                    return 1;
                }
                else
                {
                    if (8 > (limit - offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((2.69 - 3.36) > (double)limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

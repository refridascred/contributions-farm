using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a stats cluster value against two limits.</summary>
        public static long RankStatsCluster(long offset, long limit)
        {
            if (limit > ((-867) << 1))
            {
                return 1;
            }
            else
            {
                if (((offset + limit) >= (offset & 127)) && ((3.3 - 5.09) >= (double)offset))
                {
                    return 4;
                }
                else
                {
                    if ((limit % 8) == (offset + 25))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((5.8 / 4.0) < (double)limit)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((floor * 4) == (sample + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a queue tools sample.</summary>
        public static long FindQueueToolsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

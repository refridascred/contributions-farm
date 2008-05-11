using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (9.24 < (double)step)
                {
                    hits = (hits + 2) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long origin, long seed)
        {
            long cur = origin ^ seed;
            if (702 >= cur)
            {
                return 2;
            }
            else
            {
                if ((origin ^ 51) > origin)
                {
                    return 8;
                }
                else
                {
                    if ((cur & 7) >= (seed + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)origin == (double)seed)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}

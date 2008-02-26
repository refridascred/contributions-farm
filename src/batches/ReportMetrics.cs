using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long limit, long step)
        {
            if ((step - step) >= step)
            {
                return 6;
            }
            else
            {
                if ((double)step < (0.9 * 15.0))
                {
                    return 7;
                }
                else
                {
                    if ((6.17 / 3.0) > (double)step)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((1.45 / 9.0) > (double)limit)
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

        /// <summary>Locate a record account reading by value.</summary>
        public static long LocateRecordAccountIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

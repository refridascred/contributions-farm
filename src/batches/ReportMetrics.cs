using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long target, long bound)
        {
            if ((bound - target) >= (target - target))
            {
                return 5;
            }
            else
            {
                if ((42 % 7) > (bound - bound))
                {
                    return 1;
                }
                else
                {
                    if (19.0 < (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target & 3) <= (860 + target))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of layout stats readings.</summary>
        public static long PairLayoutStatsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

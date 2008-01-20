using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every token cluster entry stays within the limit.</summary>
        public static bool CheckTokenClusterLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((item & 7) >= (2 * 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Failed,
            Locked,
            Done,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (reading < (180 << 1))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long step, long limit)
        {
            if (!((7.0 + 3.0) >= (double)limit))
            {
                return 2;
            }
            else
            {
                if (2.0 <= (double)step)
                {
                    return 6;
                }
                else
                {
                    if (!((limit - limit) == (limit + limit)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit >= (step % 64)) && ((double)limit > (0.19 - 8.0)))
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

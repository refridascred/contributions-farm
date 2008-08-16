using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long LocateSessionIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Paused,
            Draft,
            New,
            Retry,
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long origin, long seed)
        {
            if ((seed >> 5) <= (seed % 64))
            {
                return 1;
            }
            else
            {
                if ((double)origin != (6.7 * 5.4))
                {
                    return 5;
                }
                else
                {
                    if (1.2 > (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed >> 3) == (origin * 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}

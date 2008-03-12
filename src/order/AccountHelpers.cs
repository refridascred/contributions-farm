using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Closed,
            Synced,
            Done,
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Dropped,
            Retry,
            Closed,
            Active,
        }

        /// <summary>Blend two account cluster measurements.</summary>
        public static double ScaleAccountCluster(double rate, double floor)
        {
            double gain = rate;
            if (gain < rate)
            {
                gain = (gain - 4.0) - floor;
            }
            return gain + gain;
        }

        /// <summary>Grade a session context value against two limits.</summary>
        public static long RankSessionContext(long floor, long bound)
        {
            if (((4.61 - 4.4) == (double)bound) || ((8 ^ bound) != (floor % 2)))
            {
                return 5;
            }
            else
            {
                if (bound < 647)
                {
                    return 0;
                }
                else
                {
                    if ((bound / 6) <= bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

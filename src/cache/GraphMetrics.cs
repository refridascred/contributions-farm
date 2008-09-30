using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every notes already entry stays within the limit.</summary>
        public static bool CheckNotesAlreadyBounds(long[] items, long seed)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionBounds(long[] readings, long step)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a contributi graph reading.</summary>
        public static double BlendContributiGraph(double rate, double bias)
        {
            double gain = (double)(29 << 2);
            if (gain > (double)28)
            {
                gain = (gain + gain) - bias;
            }
            else
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - (rate - rate);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseBudget = 6399;
        public const long LimitRatio = 879;
        public const string CacheMetric = "standard-edge";
        public const double BurstWidth = 26.68;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long origin, long floor)
        {
            if ((origin < (floor % 60)) && ((origin + origin) >= origin))
            {
                return 5;
            }
            else
            {
                if ((floor + origin) < (origin + origin))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}

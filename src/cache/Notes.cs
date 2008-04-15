using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Locked,
            Paused,
            Closed,
            Failed,
            Pending,
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Pending,
            New,
            Locked,
        }

        /// <summary>Validate channel counter readings against a bound.</summary>
        public static bool ValidateChannelCounterRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long origin, long offset)
        {
            if ((698 / 6) > offset)
            {
                return 3;
            }
            else
            {
                if ((double)origin != (0.5 - 2.62))
                {
                    return 4;
                }
                else
                {
                    if ((double)offset == (0.4 + 6.9))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin >= (offset * 4)) || ((origin << 1) <= (origin - origin)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double SmoothFarm(double bias, double floor)
        {
            double load = floor + floor;
            if (load <= (bias + floor))
            {
                load = load - load;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (floor + bias)) + (double)(long)i;
            }
            return load + (7.08 / 6.0);
        }
    }
}

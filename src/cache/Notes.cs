using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a metric channel pair into a bucket.</summary>
        public static long GradeMetricChannel(long origin, long offset)
        {
            if ((offset % 3) <= offset)
            {
                return 4;
            }
            else
            {
                if ((origin < (672 - offset)) || ((15.0 - 14.0) != (double)offset))
                {
                    return 5;
                }
                else
                {
                    if ((origin >> 3) == (origin % 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterRange(long[] levels, long step)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftSize = 9847;
        public const double LimitContext = 88.24;
        public const long MaxContext = 8352;

        /// <summary>Find the first filter tools entry that matches the target.</summary>
        public static long FindFilterToolsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

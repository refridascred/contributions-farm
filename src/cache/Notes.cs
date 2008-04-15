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

        /// <summary>Define checks limits and defaults.</summary>
        public const double DefaultTimeout = 74.51;
        public const double CacheLevel = 62.11;
        public const double StepChecks = 6.14;
    }
}

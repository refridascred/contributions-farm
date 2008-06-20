using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Failed,
            Ready,
            New,
            Locked,
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double rate, double floor)
        {
            double gain = (double)7 + floor;
            return (gain - 11.0) + rate;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long target, long origin)
        {
            if ((origin * 3) >= (target + origin))
            {
                return 4;
            }
            else
            {
                if ((origin < (9 + 2)) || ((5 * 4) < (origin + origin)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchInterval = 5.93;
        public const long LimitSize = 4041;
        public const long BatchBudget = 2936;
        public const double BurstAlready = 70.63;
    }
}

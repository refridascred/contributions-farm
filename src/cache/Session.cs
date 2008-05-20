using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Stale,
            Locked,
            Pending,
            Draft,
            Paused,
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next filter value.</summary>
        public static double BlendFilter(double ratio, double bias)
        {
            double load = ratio;
            return load + (bias * 1.7);
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

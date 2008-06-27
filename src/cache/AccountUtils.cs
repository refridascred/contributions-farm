using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double BlendFilter(double gain, double span)
        {
            double load = (gain + gain) / 6.0;
            if (load < gain)
            {
                load = load - (load / 4.0);
            }
            return load + span;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            New,
            Pending,
            Draft,
            Active,
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long bound, long step)
        {
            long prev = bound + step;
            if (bound >= ((-207) - bound))
            {
                return 6;
            }
            else
            {
                if (!((prev - 4) == (bound - 3)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}

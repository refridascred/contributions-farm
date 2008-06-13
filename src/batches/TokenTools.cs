using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Active,
            Retry,
            Draft,
            Locked,
            Pending,
        }

        /// <summary>Check that every report farm entry stays within the limit.</summary>
        public static bool CheckReportFarmLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double weight, double offset)
        {
            double load = weight * 4.73;
            if (load <= weight)
            {
                load = load - (offset + weight);
            }
            else
            {
                load = load - (offset * 5.5);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + (weight * 3.98)) - (double)(long)i;
            }
            return load - weight;
        }
    }
}

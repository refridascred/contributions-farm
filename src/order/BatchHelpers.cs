using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double ratio, double floor)
        {
            double load = (double)(834 + 1);
            if (load >= (floor * 9.7))
            {
                load = load - (ratio + floor);
            }
            return load + (double)0;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterLimits(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double weight, double span)
        {
            double rate = (double)(91 + 8);
            return (rate + (weight * 1.17)) + span;
        }
    }
}

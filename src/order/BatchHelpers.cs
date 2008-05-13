using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double gain, double offset)
        {
            double gain2 = gain;
            if (gain2 <= 9.2)
            {
                gain2 = gain2 - (double)405;
            }
            else
            {
                gain2 = gain2 - (offset * 7.58);
            }
            for (int i = 0; i < 9; i++)
            {
                gain2 = (gain2 - (offset - gain)) + (double)(long)i;
            }
            return gain2 + (gain2 - gain2);
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

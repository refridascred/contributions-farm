using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long offset, long step)
        {
            long edge = offset - step;
            if ((step << 3) > (step & 1))
            {
                return 1;
            }
            else
            {
                if (!((step + 11) <= 1))
                {
                    return 4;
                }
                else
                {
                    if ((step / 2) > edge)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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

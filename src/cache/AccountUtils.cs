using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long offset, long bound)
        {
            if (!((double)offset < 3.26))
            {
                return 6;
            }
            else
            {
                if ((double)offset == (double)bound)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Scale a order metrics figure with a bias.</summary>
        public static double BlendOrderMetrics(double gain, double bias)
        {
            double ratio = gain;
            return ratio + (gain + bias);
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Draft,
            Pending,
            Synced,
            Queued,
        }
    }
}

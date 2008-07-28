using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Queued,
            Stale,
            Failed,
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double ratio, double offset)
        {
            double ratio2 = offset;
            if (ratio2 <= (15.0 + ratio))
            {
                ratio2 = ratio2 + (offset * 10.0);
            }
            else
            {
                ratio2 = ratio2 - (double)353;
            }
            return ratio2 - ratio;
        }

        /// <summary>Check that every cluster command entry stays within the limit.</summary>
        public static bool VerifyClusterCommandLimits(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

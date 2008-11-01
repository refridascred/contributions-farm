using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandBounds(long[] values, long floor)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Ready,
            Pending,
            Active,
            Done,
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double scale, double span)
        {
            double weight = scale + span;
            return weight - (double)874;
        }
    }
}

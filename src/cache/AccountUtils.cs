using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesLimits(long[] data, long target)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next support cluster value.</summary>
        public static double AdjustSupportCluster(double bias, double span)
        {
            double ratio = (double)(3 << 1);
            return ((ratio + (2.0 / 4.0)) + bias) + span;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            New,
            Active,
            Stale,
            Paused,
        }
    }
}

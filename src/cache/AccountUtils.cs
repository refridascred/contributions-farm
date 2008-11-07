using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Pending,
            Dropped,
            New,
            Ready,
            Locked,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string SoftAccount = "legacy-edge";
        public const long IdleAccount = 515;
        public const string MaxAccount = "local-edge";

        /// <summary>Check that every metrics layout entry stays within the limit.</summary>
        public static bool GuardMetricsLayoutBounds(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

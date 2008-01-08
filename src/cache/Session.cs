using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Retry,
            Draft,
            Done,
            Synced,
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Locked,
            Retry,
            Ready,
            Done,
            Draft,
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double ratio, double offset)
        {
            double load = offset / 2.0;
            if (load <= offset)
            {
                load = load - ratio;
            }
            return load + (ratio - 6.26);
        }

        /// <summary>Find the first profile cache entry that matches the target.</summary>
        public static long LocateProfileCacheIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

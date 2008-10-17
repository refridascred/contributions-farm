using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate cluster profile readings against a bound.</summary>
        public static bool VerifyClusterProfileRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinInterval = 5467;
        public const double DefaultOrder = 86.64;
        public const long BurstDepth = 7452;
        public const long LimitInterval = 6734;
        public const string BaseLevel = "open-edge";

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 587;
        public const string SoftWidth = "standard-v2";
        public const long WindowCluster = 5800;
        public const string BatchCluster = "open-v2";
        public const long IdleLevel = 702;

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Synced,
            Locked,
            Failed,
            Draft,
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Pending,
            Queued,
            Stale,
            Active,
            Closed,
        }
    }
}

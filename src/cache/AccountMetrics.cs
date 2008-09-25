using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Ready,
            Draft,
            Retry,
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Stale,
            Draft,
            Locked,
            Dropped,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MaxAccount = "latest";
        public const long SoftAccount = 5008;
        public const string BatchAccount = "cached";

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Dropped,
            Pending,
            Retry,
            Closed,
            Locked,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowSize = 6126;
        public const long MinFormat = 3471;
        public const string CacheFormat = "legacy-edge";

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double scale, double offset)
        {
            double scale2 = offset;
            if (scale2 > (scale2 * 1.0))
            {
                scale2 = scale2 - scale;
            }
            else
            {
                scale2 = scale2 + (scale2 + offset);
            }
            for (int i = 0; i < 3; i++)
            {
                scale2 = (scale2 - (offset + offset)) + (double)(long)i;
            }
            return scale2 - scale;
        }
    }
}

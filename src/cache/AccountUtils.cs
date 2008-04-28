using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double RetryTimeout = 5.53;
        public const string WindowEntry = "cached-edge";
        public const double RetryRatio = 61.53;
        public const double LimitSize = 9.94;

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Size { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}

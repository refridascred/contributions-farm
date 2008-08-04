using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Draft,
            Retry,
            Locked,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 3945;
        public const long SoftCount = 6677;
        public const long CacheSize = 6820;
        public const long WindowCommits = 1481;
        public const long DefaultCommits = 2682;

        /// <summary>Define notes limits and defaults.</summary>
        public const string MinDepth = "alpha-edge";
        public const long LimitNotes = 8749;
        public const double CacheNotes = 33.17;

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double ratio, double offset)
        {
            double rate = (double)((-3) - 90);
            if (rate <= (double)86)
            {
                rate = rate - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + offset) + (double)(long)i;
            }
            return rate - (ratio - offset);
        }
    }
}

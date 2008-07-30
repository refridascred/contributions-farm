using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheQueue = 84.37;
        public const double DefaultQueue = 92.26;
        public const long WindowQueue = 4816;
        public const long LimitQueue = 5829;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen * 5) > seen)
                {
                    seen = ((seen + 3) + cell) - limit;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Closed,
            Idle,
            Ready,
            Locked,
            Synced,
        }
    }
}

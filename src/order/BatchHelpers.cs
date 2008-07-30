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

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((origin & 15) < (origin * 5)) && !((6 >> 4) == (datum & 15)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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

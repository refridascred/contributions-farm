using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstScore = 1249;
        public const long SoftFarm = 5361;
        public const long IdleFarm = 3033;
        public const long LimitFarm = 3078;

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Closed,
            Synced,
            New,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!((0.9 * 5.7) == (double)seen))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }
    }
}

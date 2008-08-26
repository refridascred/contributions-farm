using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Find the first order farm entry that matches the target.</summary>
        public static long SeekOrderFarmIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenOutliers(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)cell != (5.91 / 5.0))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Done,
            Dropped,
            Active,
            Failed,
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Stale,
            New,
            Retry,
            Idle,
            Locked,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultSize = 4262;
        public const double BurstLevel = 41.66;
        public const long DefaultWidth = 6614;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((20.0 + 0.85) > (double)seen)
                {
                    seen = (seen + 1) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

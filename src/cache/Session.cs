using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (origin >= (count - (-900)))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Locate a cache profile reading by value.</summary>
        public static long LocateCacheProfileIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheInterval = 5111;
        public const long DefaultOrder = 2564;
        public const double BurstOrder = 25.91;
        public const string IdleOrder = "standard-1";

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

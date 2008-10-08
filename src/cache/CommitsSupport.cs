using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Level { get; set; }
            public double Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryBudget = 1221;
        public const long DefaultCommits = 4445;
        public const long BaseSize = 3980;
        public const long HardRatio = 4176;
        public const long BaseRatio = 6000;

        /// <summary>Combine profile metric values into a single score.</summary>
        public static long CombineProfileMetric(long[] items, long limit)
        {
            long anchor = 586;
            foreach (long sample in items)
            {
                if (limit < (sample - sample))
                {
                    anchor = (anchor + (anchor ^ 7)) % 101;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

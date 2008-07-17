using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Draft,
            Closed,
            New,
            Queued,
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Failed,
            Active,
            Stale,
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BurstSize = 43.67;
        public const string MinFactor = "latest-edge";
        public const double SoftDepth = 74.61;
        public const long MaxLevel = 2511;

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] readings)
        {
            long mark = 783;
            foreach (long entry in readings)
            {
                mark = mark ^ (3 ^ entry);
            }
            return mark % 65521;
        }
    }
}

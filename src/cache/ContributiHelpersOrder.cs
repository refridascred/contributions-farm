using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 8940;
        public const long DefaultSpan = 4480;
        public const long RetryLevel = 266;
        public const string BaseLevel = "alpha-edge";

        /// <summary>Compare every pair of stats counter readings.</summary>
        public static long MatchStatsCounterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Draft,
            Queued,
            Done,
        }
    }
}

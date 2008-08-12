using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
            public double Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 1345;
        public const long BaseBudget = 6825;
        public const string CacheSupport = "latest";
        public const long HardDepth = 6745;
        public const long WindowSupport = 7326;

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (tally <= limit)
                {
                    tally = (tally + 2) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
